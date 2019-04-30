using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using CommandLine;
using Newtonsoft.Json;
using ShellProgressBar;

namespace polonadl
{
    class Program
    {
        private static readonly string baseUrl = "https://polona.pl/api";
        private static readonly HttpClient client = new HttpClient();

        public class Options
        {
            [Option("id", Required = true, HelpText = "Book ID to download")]
            public int ID { get; set; }
            [Option('o', "output", Required = true, HelpText = "Output directory")]
            public string OutputDir { get; set; }

        }

        static void Main(string[] args)
        {
            Parser.Default.ParseArguments<Options>(args)
            .WithParsed<Options>(opts => RunApplication(opts).Wait());
        }

        private static async Task RunApplication(Options opts)
        {
            int ID = opts.ID;
            string outDir = opts.OutputDir;

            try
            {
                var bookData = await GetBookData(ID);
                var pageScans = bookData.Scans.Where(
                    scan => scan.Resources.Count() != 0 && scan.Resources.Any(resource => resource.Mime == Mime.ImageJpeg)
                );
                Console.WriteLine($"Found {pageScans.Count()} scans");

                Directory.CreateDirectory(outDir);
                await DownloadBook(pageScans, outDir);
            }
            catch (ApiException e)
            {
                Console.WriteLine($"Fetching book data failed with error code {e.StatusCode}, message: {e.Content}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Something went wrong... {e.Message}");
            }
        }

        private static async Task<BookData> GetBookData(int ID)
        {
            var url = $"{baseUrl}/entities/{ID}/?format=json";

            using (var request = new HttpRequestMessage(HttpMethod.Get, url))
            using (var response = await client.SendAsync(request))
            {
                var content = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode == false)
                {
                    throw new ApiException
                    {
                        StatusCode = (int)response.StatusCode,
                        Content = content
                    };
                }

                return JsonConvert.DeserializeObject<BookData>(content);
            }
        }

        private static async Task DownloadBook(IEnumerable<Scan> scans, string outputDir)
        {
            int totalScans = scans.Count();
            int totalTicks = totalScans;
            var options = new ProgressBarOptions
            {
                ProgressCharacter = '─',
                ProgressBarOnBottom = true
            };

            using (var pbar = new ProgressBar(totalTicks, "Downloading pages...", options))
            {
                var tasks = scans.Select((scan, idx) =>
                    DownloadPage(scan, idx, totalScans, outputDir).ContinueWith(_ => pbar.Tick())
                );

                await Task.WhenAll(tasks);
            }
        }

        private static string GetFilename(int scanIdx, int totalScans)
        {
            int width = 1;
            if (totalScans >= 10000) { width = 5; }
            else if (totalScans >= 1000) { width = 4; }
            else if (totalScans >= 100) { width = 3; }
            else if (totalScans >= 10) { width = 2; }

            var template = $"D{width}";
            return scanIdx.ToString(template);
        }

        private static async Task DownloadPage(Scan scan, int scanIdx, int totalScans, string outputDir)
        {
            var jpegResource = scan.Resources.First(resource => resource.Mime == Mime.ImageJpeg);
            if (jpegResource is null)
            {
                throw new Exception($"Scan {scanIdx} has no jpegs");
            }

            var url = jpegResource.Url;
            var filepath = $"{outputDir}/{GetFilename(scanIdx, totalScans)}.jpg";

            using (HttpResponseMessage response = await client.GetAsync(url, HttpCompletionOption.ResponseHeadersRead))
            using (Stream streamToReadFrom = await response.Content.ReadAsStreamAsync())
            {
                using (Stream streamToWriteTo = File.Open(filepath, FileMode.Create))
                {
                    await streamToReadFrom.CopyToAsync(streamToWriteTo);
                }
            }
        }
    }
}
