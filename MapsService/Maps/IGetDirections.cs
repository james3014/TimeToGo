using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MapsService.Libs.Maps
{
    public interface IGetDirections
    {
        Task<string> ReturnDirectionsFromParameters(string origin, string destination);
    }
}
