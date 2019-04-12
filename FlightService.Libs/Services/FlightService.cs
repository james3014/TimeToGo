using FlightService.Libs.Flights;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static FlightService.Libs.Models.Flight;

namespace FlightService.Libs.Services
{
    public class FlightService : IFlightService
    {
        private readonly IGetFlight _getFlight;


        public FlightService(IGetFlight getFlight)
        {
            _getFlight = getFlight;
        }


        public async Task<RootObject> GetFlight()
        {
            return await _getFlight.ReturnArrival();
        }



    }
}
