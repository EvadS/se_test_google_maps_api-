using Se_Test_Google_Address_Geocoding.consts;
using Se_Test_Google_Address_Geocoding.entities;
using Se_Test_Google_Address_Geocoding.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Se_Test_Google_Address_Geocoding
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowCoordinatesAsync("1600 Amphitheatre Parkway Mountain View, CA 94043");
            ShowCoordinates("1600 Amphitheatre Parkway Mountain View, CA 94043");

            Console.WriteLine("press any key to continue....");
            Console.ReadLine();
        }


        static void ShowCoordinatesAsync(string adress)
        {
            Task<Coordinate> coordinate = GeoCodeHelper.GetCoordinatesAsync(adress);

            Console.WriteLine(string.Format("Get by Adress: {0} ", adress));

            double latitude = coordinate.Result.Latitude;
            double longitude = coordinate.Result.Longitude;

            Console.WriteLine(string.Format("\tlatitude :{0}", latitude.ToString()));
            Console.WriteLine(string.Format("\tlongitude :{0}", longitude.ToString()));

            Console.WriteLine("**************************************");
        }


        static void ShowCoordinates(string adress)
        {
            Coordinate coordinate = GeoCodeHelper.GetCoordinate(adress);

            Console.WriteLine(string.Format("Get by Adress: {0} ", adress));

            double latitude = coordinate.Latitude;
            double longitude = coordinate.Longitude;

            Console.WriteLine(string.Format("\tlatitude :{0}", latitude.ToString()));
            Console.WriteLine(string.Format("\tlongitude :{0}", longitude.ToString()));

            Console.WriteLine("**************************************");
        }
    }
}
