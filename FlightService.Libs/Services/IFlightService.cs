using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FlightService.Libs.Services
{
    public interface IFlightService
    {
        Task<string> GetFlightFromParameters(string airport, int howMany, string filter, int offset);
    }
}
