using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static MapsService.Libs.Models.MapModel;

namespace MapsService.Libs.Services
{
    public interface IMapsService
    {
        Task<RootObject> GetDirectionFromParameters(string origin);
    }
}
