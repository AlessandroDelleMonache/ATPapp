using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATPappWinForms.Classi
{
    public class Utilities
    {
        public static async void GetAgenti (string url, DataGridView dgv)
        {
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(url))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var fileJsonString = await response.Content.ReadAsStringAsync();

                        dgv.DataSource = JsonConvert.DeserializeObject<Agenti[]>(fileJsonString).ToList();
                    }
                }
            }
        }
    }
}
