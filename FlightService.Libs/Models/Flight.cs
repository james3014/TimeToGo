using System;
using System.Collections.Generic;
using System.Text;

namespace FlightService.Libs.Models
{
    public class Flight
    {
        public class Scheduled
        {
            public string Ident { get; set; }
            public string Aircrafttype { get; set; }
            public int Filed_departuretime { get; set; }
            public int Estimatedarrivaltime { get; set; }
            public string Origin { get; set; }
            public string Destination { get; set; }
            public string OriginName { get; set; }
            public string OriginCity { get; set; }
            public string DestinationName { get; set; }
            public string DestinationCity { get; set; }
        }

        public class ScheduledResult
        {
            public int Next_offset { get; set; }
            public List<Scheduled> Scheduled { get; set; }
        }

        public class RootObject
        {
            public ScheduledResult ScheduledResult { get; set; }
        }
    }
}
