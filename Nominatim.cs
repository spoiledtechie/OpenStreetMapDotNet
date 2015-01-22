using Newtonsoft.Json;
using OpenStreetMapDotNet.Enums;
using OpenStreetMapDotNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace OpenStreetMapDotNet
{
    public class Nominatim
    {
        FormatType _format;
        PolygonType _polygon;
        AddressDetailsType _addressDetail;
        const string _searchUrl = "http://nominatim.openstreetmap.org/search?";
        string _search { get; set; }

        public Nominatim(FormatType format, PolygonType polygon, AddressDetailsType addressDetail)
        {
            _format = format;
            _polygon = polygon;
            _addressDetail = addressDetail;
            _search = _searchUrl + "format=" + format.ToString() + "&polygon=" + (int)polygon + "&addressdetails=" + (int)addressDetail + "&q=";
        }

        public List<SearchResponseItem> ByZipCode(int zip)
        {
            WebClient client = new WebClient();
            string json = client.DownloadString(_search + zip);
            var convertedOb = JsonConvert.DeserializeObject<List<SearchResponseItem>>(json);

            return convertedOb;
        }

    }
}
