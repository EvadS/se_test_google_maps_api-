

using Se_Test_Google_Address_Geocoding.entities;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json;



namespace Se_Test_Google_Address_Geocoding.consts
{
    public  static class Geocode
    {
        public static readonly string _googleUri = "https://maps.googleapis.com/maps/api/geocode/";
        public static readonly string _googleKey = "AIzaSyC8iQUj6TP_9ClwRvBLlmnBIZAC7UeNxM8";
        public static readonly string _outputType = "json"; // Available options: csv, xml, kml, json
            
    }
}
