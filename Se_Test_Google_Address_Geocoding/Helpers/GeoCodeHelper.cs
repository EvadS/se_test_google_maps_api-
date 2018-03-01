using Newtonsoft.Json;
using Se_Test_Google_Address_Geocoding.consts;
using Se_Test_Google_Address_Geocoding.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Se_Test_Google_Address_Geocoding.Helpers
{
    public class GeoCodeHelper
    {
        private static Uri GetGeocodeUri(string address)
        {
            address = HttpUtility.UrlEncode(address);
            var canvertedAdress = address.Replace(" ", "+");

            return new Uri(string.Format(@"{0}{1}?address={2}+&key={3}", Geocode._googleUri, Geocode._outputType, canvertedAdress, Geocode._googleKey));
        }

        /// <summary>
        /// Gets a Coordinate from a address.
        /// </summary>
        /// <param name=”address”>An address.
        /// <remarks>
        /// <example>1600 Amphitheatre Parkway Mountain View, CA 94043</example>
        /// </remarks>
        /// </param>
        /// <returns>A spatial coordinate that contains the latitude and longitude of the address.</returns>
        public static async Task<Coordinate> GetCoordinatesAsync(string address)
        {
            Uri uri = GetGeocodeUri(address);
            double lantitude = 0.0;
            double longitude = 0.0;

            if (string.IsNullOrWhiteSpace(uri.ToString()))
            {
                return new Coordinate(lantitude, longitude);
            }
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync(uri);

            RootObject root = JsonConvert.DeserializeObject<RootObject>(response);


            foreach (var item in root.results)
            {
                lantitude = item.geometry.location.lat;
                longitude = item.geometry.location.lng;
            }

            return new Coordinate(lantitude, longitude);
        }


        public static Coordinate GetCoordinate(string address)
        {
            Uri uri = GetGeocodeUri(address);
            double lantitude = 0.0;
            double longitude = 0.0;

            if (string.IsNullOrWhiteSpace(uri.ToString()))
            {
                return new Coordinate(lantitude, longitude);
            }


            WebClient client = new WebClient();
            var response =  client.DownloadString(uri);

            RootObject root = JsonConvert.DeserializeObject<RootObject>(response);


            foreach (var item in root.results)
            {
                lantitude = item.geometry.location.lat;
                longitude = item.geometry.location.lng;
            }

            return new Coordinate(lantitude, longitude);
        }
    }
}
