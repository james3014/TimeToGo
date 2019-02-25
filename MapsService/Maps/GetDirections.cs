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
                const string mapsKey = "AIzaSyAUcN2-YKZNhFfHBtIykciiRRa3twdy2-w";
                var url = new Uri($"https://maps.googleapis.com/maps/api/directions/json?origin={origin}&destination={destination}&key={mapsKey}");

                var response = await client.GetAsync(url);

                string json;

                using (var content = response.Content)
                {
                    json = await content.ReadAsStringAsync();
                }

                return JsonConvert.DeserializeObject<MapModel>(json);
            }
        }
    }
}
