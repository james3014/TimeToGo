using MapsService.Libs.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static MapsService.Libs.Models.MapModel;

namespace MapsService.Libs.Maps
{
    public interface IGetDirections
    {
        Task<RootObject> ReturnDirectionsFromParameters(string origin, string destination);
    }
}
