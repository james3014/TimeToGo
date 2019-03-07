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
                const string mapsKey = "INSERT API KEY";
                Uri url = new Uri($"https://maps.googleapis.com/maps/api/directions/json?origin={origin}&destination={destination}&key={mapsKey}");

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
