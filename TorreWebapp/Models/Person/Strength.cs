using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TorreWebapp.Models
{
    public class Strength
    {
        public string id { get; set; }
        public int code { get; set; }
        public string name { get; set; }
        public string additionalInfo { get; set; }
        public double weight { get; set; }
        public int recommendations { get; set; }
        public List<object> media { get; set; }
        public DateTime created { get; set; }
        public string experience { get; set; }
    }
}
