using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MapsService.Libs.Maps
{
    public class GetDirections : IGetDirections
    {
        public async Task<string> ReturnDirectionsFromParameters(string origin, string destination)
        {
            using (HttpClient client = new HttpClient())
            {
                // This tells Google which API key should be used for the request and is passed at the end of the URL.
                const string mapsKey = "AIzaSyDe-lBQC5Qpk4NVcDHuqTFNPYmAyNQRTtk";

                // GET request URL
                Uri url = new Uri($"https://maps.googleapis.com/maps/api/directions/json?origin={origin}&destination={destination}&key={mapsKey}");

                // The client is passed the url for the request.
                // The response from Google Directions is stored as a HttpResponseMessage.
                HttpResponseMessage response = await client.GetAsync(url).ConfigureAwait(false);

                string mapsJson;

                // This takes the HTTP response and extracts the content. 
                using (HttpContent content = response.Content)
                {
                    // This is then assigned to the 'json' string
                    mapsJson = await content.ReadAsStringAsync().ConfigureAwait(false);
                }

                // Finally the result is returned to the Time To Go API.
                return mapsJson;
            }
        }
    }
}
