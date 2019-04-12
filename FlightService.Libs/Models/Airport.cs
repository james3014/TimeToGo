using System;
using System.Collections.Generic;
using System.Text;

namespace FlightService.Libs.Models
{
    public class Aiport
    {
        public class AirportInfoResult
        {
            public string Name { get; set; }
            public string Location { get; set; }
            public double Longitude { get; set; }
            public double Latitude { get; set; }
            public string Timezone { get; set; }
        }

        public class AirportRootObject
        {
            public AirportInfoResult AirportInfoResult { get; set; }
        }
    }
}
