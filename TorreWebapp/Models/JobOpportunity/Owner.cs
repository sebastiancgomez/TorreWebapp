using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TorreWebapp.Models.JobOpportunity
{
    public class Owner
    {
        public string id { get; set; }
        public string username { get; set; }
        public string name { get; set; }
        public bool hasEmail { get; set; }
        public string professionalHeadline { get; set; }
        public string picture { get; set; }
        public string pictureThumbnail { get; set; }
        public bool hasBio { get; set; }
        public double bioCompletion { get; set; }
        public double weight { get; set; }
        public bool verified { get; set; }
        public int subjectId { get; set; }
    }
}
