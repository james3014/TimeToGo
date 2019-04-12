using System;
using System.Collections.Generic;
using System.Text;

namespace FlightService.Libs.Models
{
    public class Flight
    {
        public class Datum
        {
            public string Ident { get; set; }
            public string Actual_ident { get; set; }
            public int Departuretime { get; set; }
            public int Arrivaltime { get; set; }
            public string Origin { get; set; }
            public string Destination { get; set; }
            public string Aircrafttype { get; set; }
            public string Meal_service { get; set; }
            public int Seats_cabin_first { get; set; }
            public int Seats_cabin_business { get; set; }
            public int Seats_cabin_coach { get; set; }
        }

        public class AirlineFlightSchedulesResult
        {
            public int Next_offset { get; set; }
            public List<Datum> Data { get; set; }
        }

        public class RootObject
        {
            public AirlineFlightSchedulesResult AirlineFlightSchedulesResult { get; set; }
        }
    }
}
