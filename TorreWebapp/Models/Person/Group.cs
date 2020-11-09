using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TorreWebapp.Models
{
    public class Group
    {
        public string id { get; set; }
        public int order { get; set; }
        public double median { get; set; }
        public double stddev { get; set; }
        public string text { get; set; }
        public string answer { get; set; }
    }
}
