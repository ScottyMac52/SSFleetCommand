using Newtonsoft.Json;

namespace SSFleetCommandModels.Enums
{
    public enum ShipType
    {
        [JsonProperty("Battleship")]
        Battleship = 1,
        [JsonProperty("Explorer")]
        Explorer = 2,
        [JsonProperty("Interceptor")]
        Interceptor = 4,
        [JsonProperty("Survey")]
        Survey = 8
    }
}
