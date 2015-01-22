﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenStreetMapDotNet.Models
{
    public class SearchResponseItem
    {
        public string place_id { get; set; }
        public string licence { get; set; }
        public string lat { get; set; }
        public string lon { get; set; }
        public string display_name { get; set; }

        public string classs { get; set; }
        public string type { get; set; }
        public string importance { get; set; }

        //public List<PolyPoint> polygonpoints { get; set; }

        public List<string> boundingbox { get; set; }
        public Address address { get; set; }
    }
}
