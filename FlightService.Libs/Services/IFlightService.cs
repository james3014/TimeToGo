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
    public interface IFlightService
    {
        Task<AirlineRootObject> GetAirlineSchedule(string startDate, string endDate, string origin);
        Task<FlightIdRootObject> GetFlightId(string ident, string departureTime);
        Task<FlightInfoRootObject> GetFlightInfo(string ident);
        Task<AirportRootObject> GetAirportInfo(string airportCode);
    }
}
