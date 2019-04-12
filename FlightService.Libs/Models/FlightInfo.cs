using System;
using System.Collections.Generic;
using System.Text;

namespace FlightService.Libs.Models
{
    public class FlightInfo
    {
        public class Flight
        {
            public string FaFlightID { get; set; }
            public string Ident { get; set; }
            public string Aircrafttype { get; set; }
            public string Filed_ete { get; set; }
            public int Filed_time { get; set; }
            public int Filed_departuretime { get; set; }
            public int Filed_airspeed_kts { get; set; }
            public string Filed_airspeed_mach { get; set; }
            public int Filed_altitude { get; set; }
            public string Route { get; set; }
            public int Actualdeparturetime { get; set; }
            public int Estimatedarrivaltime { get; set; }
            public int Actualarrivaltime { get; set; }
            public string Diverted { get; set; }
            public string Origin { get; set; }
            public string Destination { get; set; }
            public string OriginName { get; set; }
            public string OriginCity { get; set; }
            public string DestinationName { get; set; }
            public string DestinationCity { get; set; }
        }

        public class FlightInfoExResult
        {
            public int Next_offset { get; set; }
            public List<Flight> Flights { get; set; }
        }

        public class FlightInfoRootObject
        {
            public FlightInfoExResult FlightInfoExResult { get; set; }
        }
    }
}
