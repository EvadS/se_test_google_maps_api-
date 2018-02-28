using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Se_Test_Google_Address_Geocoding
{
    public interface ISpatialCoordinate
    {
        double Latitude { get; set; }
        double Longitude { get; set; }
    }
}
