using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MapsService.Libs.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TimeToGo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MapsController : ControllerBase
    {
        private readonly IMapsService _mapsService;

        public MapsController(IMapsService mapsService)
        {
            _mapsService = mapsService;
        }

        [HttpGet("{origin}/{destination}")]
        public async Task<IActionResult> GetDirections(string origin, string destination)
        {
            var result = await _mapsService.GetDirectionFromParameters(origin, destination);

            return Ok(result);
        }
    }
}