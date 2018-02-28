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
            ShowCoordinates("");
            ShowCoordinates("123");

            ShowCoordinates("1600 Amphitheatre Parkway Mountain View, CA 94043");
            ShowCoordinates("Malibu, CA 90265, United States");
            ShowCoordinates("Bhairavnath Road, Maninagar, Ahmedabad, Gujarat, India");


            ShowCoordinates("Brackley");
            ShowCoordinates("Banbury");
            ShowCoordinates("192, Nirnay Nagar Road, Nirnay Nagar, Ahmedabad, Gujarat, India");
         
         

            Console.WriteLine("press any key to continue....");
            Console.ReadLine();
        }


        static void ShowCoordinates(string adress)
        {
            Task<Coordinate> coordinate = Geocode.GetCoordinates(adress);

            Console.WriteLine(string.Format("Get by Adress: {0} ", adress));

            double latitude = coordinate.Result.Latitude;
            double longitude = coordinate.Result.Longitude;
            Console.WriteLine(string.Format("\tlatitude :{0}", latitude.ToString()));
            Console.WriteLine(string.Format("\tlongitude :{0}", longitude.ToString()));

            Console.WriteLine("**************************************");
        }
    }
}
