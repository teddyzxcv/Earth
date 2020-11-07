using System;
using System.Collections.Generic;
using System.IO;
namespace Earth
{
    public class Country
    {
        public string FullName { get; set; }
        public int Population { get; set; }
        public int AreaOfC { get; set; }
        public string Leader { get; set; }
        public string TypeOfP { get; set; }
        public long GDP { get; set; }
        public List<string> Cities { get; set; }
    }
}