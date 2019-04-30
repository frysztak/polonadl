namespace polonadl
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class BookData
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("detail")]
        public string Detail { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("alternative")]
        public object Alternative { get; set; }

        [JsonProperty("alternative_hidden")]
        public object AlternativeHidden { get; set; }

        [JsonProperty("uniform_title")]
        public object UniformTitle { get; set; }

        [JsonProperty("uniform_title_aut")]
        public object UniformTitleAut { get; set; }

        [JsonProperty("uniform_title_add")]
        public object UniformTitleAdd { get; set; }

        [JsonProperty("key_title")]
        public object KeyTitle { get; set; }

        [JsonProperty("additional_title")]
        public object AdditionalTitle { get; set; }

        [JsonProperty("former_title")]
        public object FormerTitle { get; set; }

        [JsonProperty("series_title")]
        public string[] SeriesTitle { get; set; }

        [JsonProperty("translation_of")]
        public object TranslationOf { get; set; }

        [JsonProperty("translated_as")]
        public object TranslatedAs { get; set; }

        [JsonProperty("creator")]
        public string Creator { get; set; }

        [JsonProperty("creator_name")]
        public string CreatorName { get; set; }

        [JsonProperty("creator_date")]
        public string CreatorDate { get; set; }

        [JsonProperty("creator_apposition")]
        public object CreatorApposition { get; set; }

        [JsonProperty("creator_corp")]
        public object CreatorCorp { get; set; }

        [JsonProperty("date")]
        public DateTimeOffset Date { get; set; }

        [JsonProperty("date_descriptive")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long DateDescriptive { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("publisher")]
        public string Publisher { get; set; }

        [JsonProperty("publish_place")]
        public string PublishPlace { get; set; }

        [JsonProperty("publisher_number")]
        public object PublisherNumber { get; set; }

        [JsonProperty("imprint")]
        public string Imprint { get; set; }

        [JsonProperty("frequency")]
        public object Frequency { get; set; }

        [JsonProperty("edition")]
        public string Edition { get; set; }

        [JsonProperty("series")]
        public string[] Series { get; set; }

        [JsonProperty("copublished")]
        public object Copublished { get; set; }

        [JsonProperty("chronological_term")]
        public object ChronologicalTerm { get; set; }

        // [JsonProperty("physical_description")]
        // public string PhysicalDescription { get; set; }

        [JsonProperty("file_characteristics")]
        public object FileCharacteristics { get; set; }

        [JsonProperty("categories")]
        public string[] Categories { get; set; }

        [JsonProperty("metatypes")]
        public string[] Metatypes { get; set; }

        [JsonProperty("udc")]
        public string[] Udc { get; set; }

        [JsonProperty("material_type")]
        public string MaterialType { get; set; }

        [JsonProperty("bibliographic_level")]
        public string BibliographicLevel { get; set; }

        [JsonProperty("isbn")]
        public object Isbn { get; set; }

        [JsonProperty("issn")]
        public object Issn { get; set; }

        [JsonProperty("ismn")]
        public object Ismn { get; set; }

        [JsonProperty("call_no")]
        public string[] CallNo { get; set; }

        // [JsonProperty("oclc_no")]
        // public string[] OclcNo { get; set; }

        [JsonProperty("national_bibliography")]
        public string NationalBibliography { get; set; }

        [JsonProperty("academica_id")]
        public long AcademicaId { get; set; }

        [JsonProperty("year_of_edition")]
        public object YearOfEdition { get; set; }

        [JsonProperty("tome_of_edition")]
        public object TomeOfEdition { get; set; }

        [JsonProperty("number_of_edition")]
        public object NumberOfEdition { get; set; }

        [JsonProperty("release")]
        public object Release { get; set; }

        [JsonProperty("press_title")]
        public string PressTitle { get; set; }

        [JsonProperty("languages")]
        public string[] Languages { get; set; }

        [JsonProperty("sources")]
        public string[] Sources { get; set; }

        [JsonProperty("projects")]
        public string[] Projects { get; set; }

        [JsonProperty("provenances")]
        public object[] Provenances { get; set; }

        [JsonProperty("subject")]
        public string[] Subject { get; set; }

        [JsonProperty("keywords")]
        public string[] Keywords { get; set; }

        [JsonProperty("resources")]
        public Resource[] Resources { get; set; }

        [JsonProperty("notes")]
        public object Notes { get; set; }

        [JsonProperty("literature")]
        public object Literature { get; set; }

        [JsonProperty("contents")]
        public object[] Contents { get; set; }

        [JsonProperty("has_subseries")]
        public object HasSubseries { get; set; }

        [JsonProperty("musical_presentation_statement")]
        public object MusicalPresentationStatement { get; set; }

        [JsonProperty("cartographic_math_data")]
        public object CartographicMathData { get; set; }

        [JsonProperty("rights")]
        public string[] Rights { get; set; }

        [JsonProperty("time_period_of_creation")]
        public object TimePeriodOfCreation { get; set; }

        [JsonProperty("form_and_type")]
        public string FormAndType { get; set; }

        [JsonProperty("discipline_and_approach")]
        public object DisciplineAndApproach { get; set; }

        [JsonProperty("subject_time")]
        public object SubjectTime { get; set; }

        [JsonProperty("content_of_uid")]
        public object ContentOfUid { get; set; }

        [JsonProperty("content_of")]
        public object ContentOf { get; set; }

        [JsonProperty("cultural_area")]
        public object CulturalArea { get; set; }

        [JsonProperty("audience_group")]
        public object AudienceGroup { get; set; }

        [JsonProperty("is_public")]
        public bool IsPublic { get; set; }

        [JsonProperty("digital_copy_by")]
        public string[] DigitalCopyBy { get; set; }

        [JsonProperty("link_to_original_content")]
        public object LinkToOriginalContent { get; set; }

        [JsonProperty("main_scan")]
        public Scan MainScan { get; set; }

        [JsonProperty("scans")]
        public Scan[] Scans { get; set; }

        [JsonProperty("links")]
        public Links Links { get; set; }

        [JsonProperty("has_text_content")]
        public bool HasTextContent { get; set; }

        [JsonProperty("aggregations")]
        public Aggregations Aggregations { get; set; }
    }

    public partial class Aggregations
    {
        [JsonProperty("global")]
        public Global Global { get; set; }

        [JsonProperty("user")]
        public object User { get; set; }
    }

    public partial class Global
    {
        [JsonProperty("views_count")]
        public long ViewsCount { get; set; }

        [JsonProperty("favorites_count")]
        public long FavoritesCount { get; set; }

        [JsonProperty("bookmarks_count")]
        public long BookmarksCount { get; set; }

        [JsonProperty("collections_containing_count")]
        public long CollectionsContainingCount { get; set; }

        [JsonProperty("notes_count")]
        public long NotesCount { get; set; }
    }

    public partial class Links
    {
        [JsonProperty("item_url")]
        public Uri ItemUrl { get; set; }

        [JsonProperty("academica_url")]
        public Uri AcademicaUrl { get; set; }

        [JsonProperty("catalogue_url")]
        public Uri CatalogueUrl { get; set; }
    }

    public partial class Scan
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("dzi")]
        public Dzi Dzi { get; set; }

        [JsonProperty("thumbnails")]
        public Thumbnail[] Thumbnails { get; set; }

        [JsonProperty("pagination_info")]
        public PaginationInfo PaginationInfo { get; set; }

        [JsonProperty("resources")]
        public Resource[] Resources { get; set; }

        [JsonProperty("rotation")]
        public long Rotation { get; set; }

        [JsonProperty("aggregations")]
        public Aggregations Aggregations { get; set; }
    }

    public partial class Dzi
    {
        [JsonProperty("tiles_prefix")]
        public Uri TilesPrefix { get; set; }

        [JsonProperty("manifest_url")]
        public Uri ManifestUrl { get; set; }
    }

    public partial class PaginationInfo
    {
        [JsonProperty("scan_functions")]
        public string[] ScanFunctions { get; set; }

        [JsonProperty("interesting")]
        public bool Interesting { get; set; }

        [JsonProperty("scan_structure")]
        [JsonConverter(typeof(ScanStructureConverter))]
        public ScanStructure ScanStructure { get; set; }

        [JsonProperty("page_description")]
        public object PageDescription { get; set; }

        [JsonProperty("scan_name")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? ScanName { get; set; }
    }

    public partial class Resource
    {
        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("mime")]
        [JsonConverter(typeof(MimeConverter))]
        public Mime Mime { get; set; }

        [JsonProperty("downloadable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Downloadable { get; set; }

        [JsonProperty("hidden")]
        public bool Hidden { get; set; }
    }

    public partial class Thumbnail
    {
        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("dimensions")]
        public Dimensions Dimensions { get; set; }
    }

    public partial class Dimensions
    {
        [JsonProperty("width")]
        public long Width { get; set; }

        [JsonProperty("height")]
        public long Height { get; set; }
    }

    public enum ScanStructure { SinglePage, X };

    public enum Mime { ApplicationXml, ImageJpeg, XmlAlto, PDF };

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                ScanStructureConverter.Singleton,
                MimeConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class ParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            long l;
            if (Int64.TryParse(value, out l))
            {
                return l;
            }
            throw new Exception("Cannot unmarshal type long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (long)untypedValue;
            serializer.Serialize(writer, value.ToString());
            return;
        }

        public static readonly ParseStringConverter Singleton = new ParseStringConverter();
    }

    internal class ScanStructureConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ScanStructure) || t == typeof(ScanStructure?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "SINGLE_PAGE":
                    return ScanStructure.SinglePage;
                case "X":
                    return ScanStructure.X;
            }
            throw new Exception("Cannot unmarshal type ScanStructure");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ScanStructure)untypedValue;
            switch (value)
            {
                case ScanStructure.SinglePage:
                    serializer.Serialize(writer, "SINGLE_PAGE");
                    return;
                case ScanStructure.X:
                    serializer.Serialize(writer, "X");
                    return;
            }
            throw new Exception("Cannot marshal type ScanStructure");
        }

        public static readonly ScanStructureConverter Singleton = new ScanStructureConverter();
    }

    internal class MimeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Mime) || t == typeof(Mime?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "application/xml":
                    return Mime.ApplicationXml;
                case "image/jpeg":
                    return Mime.ImageJpeg;
                case "text/xml-alto":
                    return Mime.XmlAlto;
                case "application/pdf":
                    return Mime.PDF;
            }
            throw new Exception($"Cannot unmarshal type Mime, unsupported value '{value}'");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Mime)untypedValue;
            switch (value)
            {
                case Mime.ApplicationXml:
                    serializer.Serialize(writer, "application/xml");
                    return;
                case Mime.ImageJpeg:
                    serializer.Serialize(writer, "image/jpeg");
                    return;
                case Mime.XmlAlto:
                    serializer.Serialize(writer, "text/xml-alto");
                    return;
            }
            throw new Exception("Cannot marshal type Mime");
        }

        public static readonly MimeConverter Singleton = new MimeConverter();
    }
}
