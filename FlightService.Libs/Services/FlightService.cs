using FlightService.Libs.Flights;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FlightService.Libs.Services
{
    public class FlightService : IFlightService
    {
        private readonly IGetFlight _getFlight;


        public FlightService(IGetFlight getFlight)
        {
            _getFlight = getFlight;
        }


        public async Task<string> GetFlightFromParameters(string airport, int howMany, string filter, int offset)
        {
            return await _getFlight.ReturnArrivalFromParameters(airport, howMany, filter, offset);
        }



    }
}
