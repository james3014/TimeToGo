using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
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
            using (HttpClient client = new HttpClient())
            {
                // Basic Authentication Headers
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic",
                    Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes(string.Format("{0}:{1}", "INSERT USERNAME", "INSERT API KEY"))));

                // GET request URL
                Uri url = new Uri($"http://flightxml.flightaware.com/json/FlightXML2/Enroute?airport={airport}&howMany={howMany}&filter={filter}&offset={offset}");

                HttpResponseMessage response = await client.GetAsync(url).ConfigureAwait(false);

                string json;

                using (HttpContent content = response.Content)
                {
                    json = await content.ReadAsStringAsync().ConfigureAwait(false);
                }

                RootObject result = JsonConvert.DeserializeObject<RootObject>(json);

                return result;

            }
        }
    }
}
