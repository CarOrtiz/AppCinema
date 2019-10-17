using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;

using Xamarin.Forms;

namespace CinemaDCO.Helpers
{
    public static class ApiHelpers
    {
        
        public static T Get<T>(string url)

        { 
          HttpClient client = new HttpClient();
          client.BaseAddress = new Uri("https://misapis.azurewebsites.net/api/Cartelera");

            var request = client.GetAsync(url).Result;
            if (request.IsSuccessStatusCode)
            {
                var responseJson = request.Content.ReadAsStringAsync().Result;
                var response = JsonConvert.DeserializeObject<T>(responseJson);

                return response;
            };

            return default(T);  
        }
    }
}