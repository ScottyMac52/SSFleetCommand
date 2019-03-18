using Newtonsoft.Json;

namespace SSFleetCommandModels.Models
{
    public class DraftStarSystem : StarSystemCommon
    {
        [JsonProperty("neutral")]
        public string Neutral { get; set; }

        [JsonProperty("attacked")]
        public string Attacked { get; set; }

        [JsonProperty("level")]
        public string Level { get; set; }

        [JsonProperty("has-missions")]
        public string Missions { get; set; }

        [JsonProperty("has-bases")]
        public string Bases { get; set; }

        [JsonProperty("explorer")]
        public string Explorer { get; set; }

        [JsonProperty("battleship")]
        public string Battleship { get; set; }

        [JsonProperty("interceptor")]
        public string Interceptor { get; set; }

        [JsonProperty("survey")]
        public string Survey { get; set; }

        [JsonProperty("parsteel")]
        public string Parsteel { get; set; }

        [JsonProperty("tritanium")]
        public string Tritanium { get; set; }

        [JsonProperty("dilithium")]
        public string Dilithium { get; set; }

        [JsonProperty("grade2-gas")]
        public string Gas2 { get; set; }

        [JsonProperty("grade2-ore")]
        public string Ore2 { get; set; }

        [JsonProperty("grade2-crystal")]
        public string Crystal2 { get; set; }

        [JsonProperty("grade3-gas")]
        public string Gas3 { get; set; }

        [JsonProperty("grade3-ore")]
        public string Ore3 { get; set; }

        [JsonProperty("grade3-crystal")]
        public string Crystal3 { get; set; }

        [JsonProperty("grade4-gas")]
        public string Gas4 { get; set; }

        [JsonProperty("grade4-ore")]
        public string Ore4 { get; set; }

        [JsonProperty("grade4-crystal")]
        public string Crystal4 { get; set; }
    }
}
