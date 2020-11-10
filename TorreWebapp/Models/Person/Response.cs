using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TorreWebapp.Models
{
    public class Response
    {
        public object aggregators { get; set; }
        public int offset { get; set; }
        public List<Result> results { get; set; }
    }
}
