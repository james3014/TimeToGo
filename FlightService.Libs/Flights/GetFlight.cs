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
                // Basic authentication headers are added to the HttpClient 'client' before a request is made.
                // This tells Flight Aware which username and API key should be used for the request.
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic",
                    Convert.ToBase64String(Encoding.ASCII.GetBytes(string.Format("{0}:{1}", "james3014", " 613f548bc36629f6e0ceb1ef21babcde33fb26a9"))));

                // GET request URL
                Uri url = new Uri($"http://flightxml.flightaware.com/json/FlightXML2/Enroute?airport={airport}&howMany={howMany}&filter={filter}&offset={offset}");

                // The client is passed the url for the request.
                // The response from Flight Aware is stored as a HttpResponseMessage.
                HttpResponseMessage response = await client.GetAsync(url).ConfigureAwait(false);

                string json;

                // This takes the HTTP response and extracts the content.   
                using (HttpContent content = response.Content)
                {
                    // This is then assigned to the 'json' string
                    json = await content.ReadAsStringAsync().ConfigureAwait(false);
                }

                //The json string is then deserialized using JsonConvert into a RootObject model.
                RootObject result = JsonConvert.DeserializeObject<RootObject>(json);

                // Finally the result is returned to the Time To Go API.
                return result;

            }
        }
    }
}
