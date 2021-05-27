using Newtonsoft.Json;

namespace Models.NumberFact
{
    public class NumberFact
    {
        [JsonProperty("text")]
        public string Fact { get; set; }

        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("found")]
        public bool Found { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}