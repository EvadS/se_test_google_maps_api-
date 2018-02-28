using Se_Test_Google_Address_Geocoding.consts;
using Se_Test_Google_Address_Geocoding.enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Se_Test_Google_Address_Geocoding.entities
{
    public class Address
    {
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }

        private LatLngAccurateToTypes _LatLngAccuracy = 0;
        public LatLngAccurateToTypes LatLngAccuracy
        {
            get { return _LatLngAccuracy; }
        }

        public override string ToString()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.AppendLine(Line1);
            if (!string.IsNullOrEmpty(Line2)) sb.AppendLine(Line2);
            sb.Append(City);
            sb.Append(", ");
            sb.Append(State);
            sb.Append(" ");
            sb.Append(Zip);
            sb.Append(" ");
            sb.Append(Country);
            return sb.ToString();
        }

        public Address()
        {
        }
    }
     
}
