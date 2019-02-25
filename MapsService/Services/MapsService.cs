using MapsService.Libs.Maps;
using MapsService.Libs.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MapsService.Libs.Services
{
    public class MapsService : IMapsService
    {
        private readonly IGetDirections _getDirections;

        public MapsService(IGetDirections getDirections)
        {
            _getDirections = getDirections;
        }

        public async Task<MapModel> GetDirectionFromParameters(string origin, string destination)
        {
            return await _getDirections.ReturnDirectionsFromParameters(origin, destination);
        }
    }
}
