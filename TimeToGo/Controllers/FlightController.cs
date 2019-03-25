using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlightService.Libs.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TimeToGo.Api.Controllers
{
    public class FlightController : ControllerBase
    {
        private IFlightService _flightService;

        public FlightController(IFlightService flightService)
        {
            _flightService = flightService;
        }

        [HttpGet("get/flights/{airport}&{howMany}&{filter}&{offset}")]
        public async Task<OkObjectResult> GetFlight(string airport, int howMany, string filter, int offset)
        {
            string result = await _flightService.GetFlightFromParameters(airport, howMany, filter, offset);

            return Ok(result);      
        }
    }
}