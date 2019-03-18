using Newtonsoft.Json;
using System;

namespace SSFleetCommandModels.Models
{
    public class MiningLog
    {
        [JsonProperty("ship")]
        public string Ship { get; set; }

        [JsonProperty("captain")]
        public string Captain { get; set; }

        [JsonProperty("resource-goal")]
        public DynamicResourceType ResourceGoal { get; set; }

        [JsonProperty("system")]
        public DraftStarSystem System { get; set; }

        [JsonProperty("rate", NullValueHandling = NullValueHandling.Ignore)]
        public int? MiningRate { get; set; }

        [JsonProperty("resource-achieved", NullValueHandling = NullValueHandling.Ignore)]
        public DynamicResourceType ResourceAchieved { get; set; }

        [JsonProperty("depart", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Depart { get; set; }

        [JsonProperty("arrive", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Arrive { get; set; }

        [JsonProperty("start", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Start { get; set; }

        [JsonProperty("finish", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Finish { get; set; }

        [JsonProperty("attacked")]
        public bool Attacked { get; set; }

        [JsonProperty("lost")]
        public DynamicResourceType ResourceLost { get; set; }

        [JsonProperty("estimate-done", Required = Required.AllowNull, NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? EstimateDone => GetEstimateDone();

        private DateTime? GetEstimateDone()
        {
            return Start?.AddMinutes((ResourceGoal?.Quantity ?? 0.00) / (MiningRate ?? 1)); 
        }
    }
}
