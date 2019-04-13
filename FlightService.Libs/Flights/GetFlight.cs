using FlightService.Libs.Models;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using static FlightService.Libs.Models.Aiport;
using static FlightService.Libs.Models.AirlineSchedule;
using static FlightService.Libs.Models.FlightID;
using static FlightService.Libs.Models.FlightInfo;

namespace FlightService.Libs.Flights
{
    public class GetFlight : IGetFlight
    {
        private readonly string username = "USERNAME";
        private readonly string apiKey = "API KEY";

        public async Task<AirlineRootObject> ReturnSchedule(string startDate, string endDate, string origin)
        { 
            using (HttpClient client = new HttpClient())
            {
                // Basic authentication headers are added to the HttpClient 'client' before a request is made.
                // This tells Flight Aware which username and API key should be used for the request.
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic",
                    Convert.ToBase64String(Encoding.ASCII.GetBytes(string.Format("{0}:{1}", username, apiKey))));

                //int startDate = (int)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
                //int endDate = startDate + 43200;

                // GET request URL
                if (origin != "*")
                {
                    Uri url = new Uri($"http://flightxml.flightaware.com/json/FlightXML2/AirlineFlightSchedules?startDate={startDate}&endDate={endDate}&origin={origin}&destination=EGPF&howMany=10&offset=0");

                    HttpResponseMessage response = await client.GetAsync(url).ConfigureAwait(false);

                    // The client is passed the url for the request.
                    // The response from Flight Aware is stored as a HttpResponseMessage.
                    string json;

                    // This takes the HTTP response and extracts the content.   
                    using (HttpContent content = response.Content)
                    {
                        // This is then assigned to the 'json' string
                        json = await content.ReadAsStringAsync().ConfigureAwait(false);
                    }

                    AirlineRootObject result = JsonConvert.DeserializeObject<AirlineRootObject>(json);

                    return result;
                }
                else
                {
                    Uri url = new Uri($"http://flightxml.flightaware.com/json/FlightXML2/AirlineFlightSchedules?startDate={startDate}&endDate={endDate}&destination=EGPF&howMany=10&offset=0");

                    HttpResponseMessage response = await client.GetAsync(url).ConfigureAwait(false);

                    string json;

                    using (HttpContent content = response.Content)
                    {
                        json = await content.ReadAsStringAsync().ConfigureAwait(false);
                    }

                    AirlineRootObject result = JsonConvert.DeserializeObject<AirlineRootObject>(json);

                    return result;
                }
            }
        }

        public async Task<FlightIdRootObject> ReturnFlightId(string ident, string departureTime)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic",
                    Convert.ToBase64String(Encoding.ASCII.GetBytes(string.Format("{0}:{1}", username, apiKey))));

                Uri url = new Uri($"http://flightxml.flightaware.com/json/FlightXML2/GetFlightID?ident={ident}&departureTime={departureTime}");

                HttpResponseMessage response = await client.GetAsync(url).ConfigureAwait(false);

                string json;
 
                using (HttpContent content = response.Content)
                {
                    json = await content.ReadAsStringAsync().ConfigureAwait(false);
                }

                FlightIdRootObject result = JsonConvert.DeserializeObject<FlightIdRootObject>(json);

                return result;
            }
        }

        public async Task<FlightInfoRootObject> ReturnFlightInfo(string ident)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic",
                    Convert.ToBase64String(Encoding.ASCII.GetBytes(string.Format("{0}:{1}", username, apiKey))));

                Uri url = new Uri($"http://flightxml.flightaware.com/json/FlightXML2/FlightInfoEx?ident={ident}&howMany=10&offset=0");

                HttpResponseMessage response = await client.GetAsync(url).ConfigureAwait(false);

                string json;

                using (HttpContent content = response.Content)
                {
                    json = await content.ReadAsStringAsync().ConfigureAwait(false);
                }

                FlightInfoRootObject result = JsonConvert.DeserializeObject<FlightInfoRootObject>(json);

                return result;
            }
        }

        public async Task<AirportRootObject> ReturnAirportInfo(string airportCode)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic",
                    Convert.ToBase64String(Encoding.ASCII.GetBytes(string.Format("{0}:{1}", username, apiKey))));

                Uri url = new Uri($"http://flightxml.flightaware.com/json/FlightXML2/AirportInfo?airportCode={airportCode}");

                HttpResponseMessage response = await client.GetAsync(url).ConfigureAwait(false);

                string json;

                using (HttpContent content = response.Content)
                {
                    json = await content.ReadAsStringAsync().ConfigureAwait(false);
                }

                AirportRootObject result = JsonConvert.DeserializeObject<AirportRootObject>(json);

                return result;
            }
        }
    }
}
