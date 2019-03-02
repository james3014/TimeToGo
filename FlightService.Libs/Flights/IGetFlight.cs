using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static FlightService.Libs.Models.Flight;

namespace FlightService.Libs.Flights
{
    public interface IGetFlight
    {
        Task<RootObject> ReturnArrivalFromParameters(string airport, int howMany, string filter, int offset);
    }
}