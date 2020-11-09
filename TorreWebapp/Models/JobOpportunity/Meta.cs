using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TorreWebapp.Models.JobOpportunity
{
    public class Meta
    {
        public double rank { get; set; }
        public Scorer scorer { get; set; }
        public object filter { get; set; }
        public List<string> boosters { get; set; }
    }
}
