using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Se_Test_Google_Address_Geocoding.enums
{
    public enum LatLngAccurateToTypes : int
    {
        Unknown = 0,
        Country = 1,
        Region = 2,
        SubRegion = 3,
        Town = 4,
        PostCode = 5,
        Street = 6,
        Intersection = 7,
        Address = 8,
        Premises = 9
    }
}
