using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using static FlightService.Libs.Models.Flight;

namespace FlightService.Libs.Flights
{
    public class GetFlight : IGetFlight
    {
        public async Task<RootObject> ReturnArrivalFromParameters(string airport, int howMany, string filter, int offset)
        {
            using (var client = new HttpClient())
            {
                /// Authentication Headers Required ///

                var url = new Uri($"http://flightxml.flightaware.com/json/FlightXML2/Scheduled?airport=EGPF&howMany=1&filter=airline&offset=0");

                var response = await client.GetAsync(url).ConfigureAwait(false);

                string json;

                using (var content = response.Content)
                {
                    json = await content.ReadAsStringAsync().ConfigureAwait(false);
                }

                RootObject result = JsonConvert.DeserializeObject<RootObject>(json);

                return result;

            }
        }
    }
}
