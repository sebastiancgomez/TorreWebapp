using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TorreWebapp.Models
{
    public class Opportunity
    {
        public string id { get; set; }
        public string interest { get; set; }
        public string field { get; set; }
        public object data { get; set; }
    }
}
