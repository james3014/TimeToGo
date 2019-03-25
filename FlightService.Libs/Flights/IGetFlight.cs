using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FlightService.Libs.Flights
{
    public interface IGetFlight
    {
        Task<string> ReturnArrivalFromParameters(string airport, int howMany, string filter, int offset);
    }
}