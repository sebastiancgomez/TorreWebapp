using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TorreWebapp.Models.JobOpportunity
{
    public class Scorer
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public double score { get; set; }
        public List<And> and { get; set; }
    }
}
