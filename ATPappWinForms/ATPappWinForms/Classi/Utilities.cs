using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ATPappWinforms.Classi
{
    public class Utilities
    {
        public static async Task RunAsync(HttpClient client)
        {
            // Update port # in the following line.
            client.BaseAddress = new Uri("http://atpapirest.azurewebsites.net/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public static async Task<Agenti> GetAgentiAsync (string path, HttpClient client)
        {
            Agenti agente = null;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                agente = await response.Content.ReadAsAsync<Agenti>();
            }
            return agente;
        }
    }
}
