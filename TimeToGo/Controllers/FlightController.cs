using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlightService.Libs.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static FlightService.Libs.Models.Aiport;
using static FlightService.Libs.Models.AirlineSchedule;
using static FlightService.Libs.Models.FlightID;
using static FlightService.Libs.Models.FlightInfo;

namespace TimeToGo.Api.Controllers
{
    [ApiController]
    public class FlightController : ControllerBase
    {
        private IFlightService _flightService;

        public FlightController(IFlightService flightService)
        {
            _flightService = flightService;
        }

        [HttpGet("/airlineschedule/{startDate}&{endDate}&{origin}")]
        public async Task<IActionResult> GetAirlineSchedule(string startDate, string endDate, string origin)
        {
            AirlineRootObject result = await _flightService.GetAirlineSchedule(startDate, endDate, origin);

            return Ok(result);      
        }

        [HttpGet("/flightid/{ident}&{departureTime}")]
        public async Task<IActionResult> GetFlightId(string ident, string departureTime)
        {
            FlightIdRootObject result = await _flightService.GetFlightId(ident, departureTime);

            return Ok(result);
        }

        [HttpGet("/flightinfo/{ident}")]
        public async Task<IActionResult> GetFlightInfo(string ident)
        {
            FlightInfoRootObject result = await _flightService.GetFlightInfo(ident);

            return Ok(result);
        }

        [HttpGet("/airport/{airportCode}")]
        public async Task<IActionResult> GetAirport(string airportCode)
        {
            AirportRootObject result = await _flightService.GetAirportInfo(airportCode);

            return Ok(result);
        }
    }
}