using FlightService.Libs.Flights;
using FlightService.Libs.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static FlightService.Libs.Models.Aiport;
using static FlightService.Libs.Models.AirlineSchedule;
using static FlightService.Libs.Models.FlightID;
using static FlightService.Libs.Models.FlightInfo;

namespace FlightService.Libs.Services
{
    public class FlightService : IFlightService
    {
        private readonly IGetFlight _getFlight;


        public FlightService(IGetFlight getFlight)
        {
            _getFlight = getFlight;
        }

        public async Task<AirlineRootObject> GetAirlineSchedule()
        {
            return await _getFlight.ReturnSchedule();
        }

        public async Task<AirportRootObject> GetAirportInfo()
        {
            return await _getFlight.ReturnAirportInfo();
        }

        public async Task<FlightIdRootObject> GetFlightId(string ident, string departureTime)
        {
            return await _getFlight.ReturnFlightId(ident, departureTime);
        }

        public async Task<FlightInfoRootObject> GetFlightInfo(string ident)
        {
            return await _getFlight.ReturnFlightInfo(ident);
        }
    }
}
