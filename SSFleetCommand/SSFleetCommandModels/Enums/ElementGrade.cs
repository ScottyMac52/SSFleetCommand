using Newtonsoft.Json;

namespace SSFleetCommandModels.Enums
{
    public enum ElementGrade
    {
        [JsonProperty("none")]
        None = 0,
        [JsonProperty("1")]
        One = 1,
        [JsonProperty("2")]
        Two = 2,
        [JsonProperty("3")]
        Three = 3,
        [JsonProperty("4")]
        Four = 4
    }
}
