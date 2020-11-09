using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TorreWebapp.Models.JobOpportunity
{
    public class Language
    {
        public string fluency { get; set; }        
        public LanguageDetail language { get; set; }
    }

    public class LanguageDetail
    {
        public string code { get; set; }
        public string name { get; set; }
    }
}
