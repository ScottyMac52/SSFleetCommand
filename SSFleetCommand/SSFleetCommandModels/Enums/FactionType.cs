using Newtonsoft.Json;

namespace SSFleetCommandModels.Enums
{
    public enum FactionType
    {
        [JsonProperty("Federation")]
        Federation = 1,
        [JsonProperty("Klingon")]
        Klingon = 2,
        [JsonProperty("Romulan")]
        Romulan = 4
    }
}
