using System;
using System.Collections.Generic;
using System.Text;

namespace FlightService.Libs.Models
{
    public class Flight
    {
        public class Enroute
        {
            public string ident { get; set; }
            public string aircrafttype { get; set; }
            public int actualdeparturetime { get; set; }
            public int estimatedarrivaltime { get; set; }
            public int filed_departuretime { get; set; }
            public string origin { get; set; }
            public string destination { get; set; }
            public string originName { get; set; }
            public string originCity { get; set; }
            public string destinationName { get; set; }
            public string destinationCity { get; set; }
        }

        public class EnrouteResult
        {
            public int next_offset { get; set; }
            public List<Enroute> enroute { get; set; }
        }

        public class RootObject
        {
            public EnrouteResult EnrouteResult { get; set; }
        }
    }
}
