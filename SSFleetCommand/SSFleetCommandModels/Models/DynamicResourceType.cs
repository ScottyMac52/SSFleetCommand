using Newtonsoft.Json;

namespace SSFleetCommandModels.Models
{
    public class DynamicResourceType : ResourceType
    {
        [JsonProperty("quantity")]
        public int Quantity { get; set; }
    }
}
