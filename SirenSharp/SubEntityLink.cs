using System;
using System.Collections.Generic;

namespace SirenSharp
{
    public class SubEntityLink
    {
        public SubEntityLink()
        {
        }
 
        public Uri Href { get; set; }
        public string Title { get; set; }
        public IEnumerable<string> Rel { get; set; }
        public IEnumerable<string> Class { get; set; }

    }
}