using Newtonsoft.Json;

namespace SSFleetCommandModels.Enums
{
    public enum ElementRefinement
    {
        [JsonProperty("common")]
        Common = 1,
        [JsonProperty("uncommon")]
        UnCommon = 2,
        [JsonProperty("rare")]
        Rare = 4
    }
}
