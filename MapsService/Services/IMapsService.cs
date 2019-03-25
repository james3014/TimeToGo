using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MapsService.Libs.Services
{
    public interface IMapsService
    {
        Task<string> GetDirectionFromParameters(string origin, string destination);
    }
}
