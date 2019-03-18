using Newtonsoft.Json;

namespace SSFleetCommandModels.Models
{
    public class RefinedDynamicResourceType : RefinedResourceType
    {
        [JsonProperty("quantity")]
        public int Quantity { get; set; }
    }
}
