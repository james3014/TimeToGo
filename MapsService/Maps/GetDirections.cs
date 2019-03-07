using MapsService.Libs.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using static MapsService.Libs.Models.MapModel;

namespace MapsService.Libs.Maps
{
    public class GetDirections : IGetDirections
    {
        public async Task<RootObject> ReturnDirectionsFromParameters(string origin, string destination)
        {
            using (HttpClient client = new HttpClient())
            {
                // This tells Google which API key should be used for the request and is passed at the end of the URL.
                const string mapsKey = "INSERT API KEY";

                // GET request URL
                Uri url = new Uri($"https://maps.googleapis.com/maps/api/directions/json?origin={origin}&destination={destination}&key={mapsKey}");

                // The client is passed the url for the request.
                // The response from Google Directions is stored as a HttpResponseMessage.
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
