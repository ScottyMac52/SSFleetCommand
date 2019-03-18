using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SSFleetCommandModels.Models
{
    public class StarSystemCommon
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("faction")]
        public string Faction { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }
    }
}
