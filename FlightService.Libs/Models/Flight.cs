using System;
using System.Collections.Generic;
using System.Text;

namespace FlightService.Libs.Models
{
    public class Flight
    {
        public class Metar
        {
            public string Airport { get; set; }
            public int Time { get; set; }
            public string Cloud_friendly { get; set; }
            public int Cloud_altitude { get; set; }
            public string Cloud_type { get; set; }
            public string Conditions { get; set; }
            public double Pressure { get; set; }
            public int Temp_air { get; set; }
            public int Temp_dewpoint { get; set; }
            public int Temp_relhum { get; set; }
            public int Visibility { get; set; }
            public string Wind_friendly { get; set; }
            public int Wind_direction { get; set; }
            public int Wind_speed { get; set; }
            public int Wind_speed_gust { get; set; }
            public string Raw_data { get; set; }
        }
        
        public class MetarExResult
        {
            public int Next_offset { get; set; }
            public List<Metar> Metar { get; set; }
        }

        public class RootObject
        {
            public MetarExResult MetarExResult { get; set; }
        }
    }
}
