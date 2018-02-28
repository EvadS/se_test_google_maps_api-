using Se_Test_Google_Address_Geocoding.consts;
using Se_Test_Google_Address_Geocoding.entities;
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
            Task<Coordinate> coordinate =  Geocode.GetCoordinates("1600 Amphitheatre Parkway Mountain View, CA 94043");

            double latitude = coordinate.Result.Latitude;
            double longitude = coordinate.Result.Longitude;


            Console.WriteLine(string.Format("latitude :{0}", latitude.ToString()));
            Console.WriteLine(string.Format("longitude :{0}", longitude.ToString()));

            Console.WriteLine("press any key to continue....");
            Console.ReadLine();
        }
    }
}
