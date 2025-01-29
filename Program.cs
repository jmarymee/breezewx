using System;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Breezewx
{

    public class ApiClient
    {
        private static readonly HttpClient client = new HttpClient();

        public static async Task<string> GetApiResponseAsync(string url)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                return responseBody;
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"Request error: {e.Message}");
                return null;
            }
        }

        public static async Task<String> GetMetar()
        {
            client.BaseAddress = new Uri("https://aviationweather.gov/api/data/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("User-Agent", "Breezewx");
            HttpResponseMessage response =  await client.GetAsync("metar?ids=KSEA&format=json");

            string respBody =  await response.Content.ReadAsStringAsync();
            return respBody;
        }

        public static async Task Main(string[] args)
        {
            //string url = "https://aviationweather.gov/api/data/metar?ids=KSEA&format=json";
            //string response = await GetApiResponseAsync(url);
            //Console.WriteLine(response);

            string reps2 = await GetMetar();
            Console.WriteLine(reps2);
        }
    }
}