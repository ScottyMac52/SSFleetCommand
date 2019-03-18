using Newtonsoft.Json;

namespace SSFleetCommandModels.Enums
{
    public enum ElementType
    {
        [JsonProperty("dilithium")]
        Dilithium = 1,
        [JsonProperty("parsteel")]
        Parsteel = 2,
        [JsonProperty("tritanium")]
        Tritanium = 4,
        [JsonProperty("crystal")]
        Crystal = 8,
        [JsonProperty("gas")]
        Gas = 16,
        [JsonProperty("ore")]
        Ore = 32
    }
}
