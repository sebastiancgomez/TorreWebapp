using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TorreWebapp.Models.JobOpportunity
{
    public class Compensation
    {
        public Data data { get; set; }
        public bool visible { get; set; }
        public string code { get; set; }
        public string currency { get; set; }
        public double? minAmount { get; set; }
        public double? maxAmount { get; set; }
        public string periodicity { get; set; }
    }
}
