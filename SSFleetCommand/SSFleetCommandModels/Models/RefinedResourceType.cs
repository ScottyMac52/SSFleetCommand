using Newtonsoft.Json;
using SSFleetCommandModels.Enums;

namespace SSFleetCommandModels.Models
{
    public class RefinedResourceType : ResourceType
    {
        [JsonProperty("refinement")]
        public ElementRefinement Refinement { get; set; }
    }
}
