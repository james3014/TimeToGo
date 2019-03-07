using System;
using System.Collections.Generic;
using System.Text;

namespace FlightService.Libs.Models
{
    public class Flight
    {
        public class Enroute
        {
            public string Ident { get; set; }
            public string Aircrafttype { get; set; }
            public int Actualdeparturetime { get; set; }
            public int Estimatedarrivaltime { get; set; }
            public int Filed_departuretime { get; set; }
            public string Origin { get; set; }
            public string Destination { get; set; }
            public string OriginName { get; set; }
            public string OriginCity { get; set; }
            public string DestinationName { get; set; }
            public string DestinationCity { get; set; }
        }

        public class EnrouteResult
        {
            public int Next_offset { get; set; }
            public List<Enroute> Enroute { get; set; }
        }

        public class RootObject
        {
            public EnrouteResult EnrouteResult { get; set; }
        }
    }
}
