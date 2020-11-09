using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TorreWebapp.Models.JobOpportunity
{
    public class Request
    {
        [JsonProperty("skill/role")]
        public Skill skill { get; set; }
        public Organization organization { get; set; }
    }
}

