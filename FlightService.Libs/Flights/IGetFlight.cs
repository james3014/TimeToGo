using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static FlightService.Libs.Models.Aiport;
using static FlightService.Libs.Models.AirlineSchedule;
using static FlightService.Libs.Models.FlightID;
using static FlightService.Libs.Models.FlightInfo;

namespace FlightService.Libs.Flights
{
    public interface IGetFlight
    {
        Task<AirlineRootObject> ReturnSchedule(string startDate, string endDate, string origin);
        Task<FlightIdRootObject> ReturnFlightId(string ident, string departureTime);
        Task<FlightInfoRootObject> ReturnFlightInfo(string ident);
        Task<AirportRootObject> ReturnAirportInfo();
    }
}