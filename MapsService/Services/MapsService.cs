using MapsService.Libs.Maps;
using MapsService.Libs.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static MapsService.Libs.Models.MapModel;

namespace MapsService.Libs.Services
{
    public class MapsService : IMapsService
    {
        private readonly IGetDirections _getDirections;

        public MapsService(IGetDirections getDirections)
        {
            _getDirections = getDirections;
        }

        public async Task<RootObject> GetDirectionFromParameters(string origin, string destination)
        {
            return await _getDirections.ReturnDirectionsFromParameters(origin, destination);
        }
    }
}
