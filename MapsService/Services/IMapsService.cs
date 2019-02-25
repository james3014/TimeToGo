using MapsService.Libs.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MapsService.Libs.Services
{
    public interface IMapsService
    {
        Task<MapModel> GetDirectionFromParameters(string origin, string destination);
    }
}
