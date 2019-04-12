using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MapsService.Libs.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static MapsService.Libs.Models.MapModel;

namespace TimeToGo.Controllers
{
    [ApiController]
    public class MapsController : ControllerBase
    {
        private readonly IMapsService _mapsService;

        public MapsController(IMapsService mapsService)
        {
            _mapsService = mapsService;
        }

        [HttpGet("/directions/{origin}")]
        public async Task<IActionResult> GetDirections(string origin)
        {
            RootObject result = await _mapsService.GetDirectionFromParameters(origin);

            return Ok(result);
        }
    }
}