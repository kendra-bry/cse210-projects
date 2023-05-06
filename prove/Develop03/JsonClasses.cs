using System.Text.Json.Serialization;

namespace JsonClasses
{
    public class ScriptureApiResponse
    {
        [JsonPropertyName("api")]
        public ApiResponse Api { get; set; }

        [JsonPropertyName("scriptures")]
        public Scriptures[] Scriptures { get; set; }

    }

    public class Scriptures
    {
        [JsonPropertyName("scripture")]
        public string Scripture { get; set; }

        [JsonPropertyName("book")]
        public string Book { get; set; }

        [JsonPropertyName("chapter")]
        public int Chapter { get; set; }

        [JsonPropertyName("verse")]
        public int Verse { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }

    }

    public class ApiResponse
    {
        [JsonPropertyName("q")]
        public string Q { get; set; }

        [JsonPropertyName("format")]
        public string Format { get; set; }

    }

}
