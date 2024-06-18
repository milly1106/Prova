using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using ExemploHTTP.Models;
using System.Text.Json;
using System.Diagnostics;

namespace ExemploHTTP.Services
{
    public class RestService
    {
        private HttpClient client;
        private Fotos foto;
        private List<Fotos> foto;
        private JsonSerializerOptions _serializeOptions;

        RestService()
        {
            client = new HttpClient();
            _serializeOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true,
            };
            

             
        
        }

        public async Task<List<Fotos>> getFotosAsync()
        {
            Uri uri = new Uri("https://jsonplaceholder.typicode.com/photos");
            try
            {




                HttpResponseMessage response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {

                    string content = await response.Content.ReadAsStringAsync();
                    foto = JsonSerializer.Deserialize<List<Fotos>>(content, _serializeOptions);

                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

            return foto;

        }

    }
}
