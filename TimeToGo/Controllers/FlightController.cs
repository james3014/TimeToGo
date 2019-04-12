using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlightService.Libs.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static FlightService.Libs.Models.Flight;

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

        [HttpGet("/flights")]
        public async Task<IActionResult> GetFlight()
        {
            RootObject result = await _flightService.GetFlight();

            return Ok(result);      
        }
    }
}