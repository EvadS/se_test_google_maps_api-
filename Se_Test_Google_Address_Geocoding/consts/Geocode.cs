

using Se_Test_Google_Address_Geocoding.entities;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json;



namespace Se_Test_Google_Address_Geocoding.consts
{
    public class Geocode
    {
        private const string _googleUri = "https://maps.googleapis.com/maps/api/geocode/";
        private const string _googleKey = "AIzaSyC8iQUj6TP_9ClwRvBLlmnBIZAC7UeNxM8";
        private const string _outputType = "json"; // Available options: csv, xml, kml, json


        private static Uri GetGeocodeUri(string address)
        {
            address = HttpUtility.UrlEncode(address);
            var canvertedAdress = address.Replace(" ","+");

            return new Uri(string.Format(@"{0}{1}?address={2}+&key={3}", _googleUri, _outputType, canvertedAdress, _googleKey));
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
        public static async Task<Coordinate> GetCoordinates(string address)
        {     
            Uri uri = GetGeocodeUri(address);
    
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync(uri);
        
            RootObject root = JsonConvert.DeserializeObject<RootObject>(response);
            double lantitude = 0.0;
            double longitude = 0.0;

            foreach(var item in root.results)
            {
                lantitude = item.geometry.location.lat;
                longitude = item.geometry.location.lng; 
            }

            return new Coordinate(lantitude, longitude);
        }

    }
}
