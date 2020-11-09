using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TorreWebapp.Models.JobOpportunity
{
    public class And
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public string id { get; set; }
        public Input input { get; set; }
        public double score { get; set; }
    }
}
