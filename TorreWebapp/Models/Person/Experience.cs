﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TorreWebapp.Models
{
    public class Experience
    {
        public string id { get; set; }
        public string category { get; set; }
        public string name { get; set; }
        public List<Organization> organizations { get; set; }
        public List<string> responsibilities { get; set; }
        public string fromMonth { get; set; }
        public string fromYear { get; set; }
        public string toMonth { get; set; }
        public string toYear { get; set; }
        public bool highlighted { get; set; }
        public double weight { get; set; }
        public int verifications { get; set; }
        public int recommendations { get; set; }
        public List<object> media { get; set; }
        public double rank { get; set; }
    }
}
