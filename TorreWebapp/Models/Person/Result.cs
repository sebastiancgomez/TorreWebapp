using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TorreWebapp.Models.JobOpportunity;

namespace TorreWebapp.Models
{
    public class Result
    {
        public Compensations compensations { get; set; }
        public string locationName { get; set; }
        public string name { get; set; }
        public List<string> openTo { get; set; }
        public string picture { get; set; }
        public string professionalHeadline { get; set; }
        public bool remoter { get; set; }
        public List<Skill> skills { get; set; }
        public string subjectId { get; set; }
        public string username { get; set; }
        public bool verified { get; set; }
        public double weight { get; set; }
    }
}
