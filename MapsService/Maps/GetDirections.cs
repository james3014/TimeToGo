using MapsService.Libs.Models;
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
        public async Task<MapModel> ReturnDirectionsFromParameters(string origin, string destination)
        {
            using (var client = new HttpClient())
            {
                const string mapsKey = "Insert API Key";
                var url = new Uri($"https://maps.googleapis.com/maps/api/directions/json?origin={origin}&destination={destination}&key={mapsKey}");

                var response = await client.GetAsync(url).ConfigureAwait(false);

                string json;

                using (var content = response.Content)
                {
                    json = await content.ReadAsStringAsync().ConfigureAwait(false);
                }

                return JsonConvert.DeserializeObject<MapModel>(json);
            }
        }
    }
}
