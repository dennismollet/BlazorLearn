using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Blazor.Models;
using Newtonsoft.Json;

namespace Blazor.Services.Implementations
{
    public class PeopleService : IPeopleService
    {
        public async Task<People> GetValue(int id)
        {
            People response = new People();

            using (var http = new HttpClient())
            {
                var responseRequest = await http.GetStringAsync($"http://localhost:8080/api/people/{id}");
                response = JsonConvert.DeserializeObject<People>(responseRequest);
            }
            return response;
        }

        public async Task<List<People>> GetValues()
        {
            System.Console.WriteLine("Getting Values");
            List<People> response = new List<People>();

            System.Console.WriteLine("Beginning web call");
            using (var http = new HttpClient())
            {
                var responseRequest = await http.GetStringAsync("http://localhost:8080/api/people");
                response = JsonConvert.DeserializeObject<List<People>>(responseRequest);
            }
            System.Console.WriteLine(response.Count);
            return response;
        }

        public async Task<People> Post(People value)
        {
            using (var http = new HttpClient())
            {
                System.Console.WriteLine("posting");
                var content = new StringContent(JsonConvert.SerializeObject(value));
                content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                var responseRequest = await http.PostAsync("http://localhost:8080/api/people", content);
                return JsonConvert.DeserializeObject<People>(await responseRequest.Content.ReadAsStringAsync());
            }
        }

        public async Task<HttpStatusCode> Put(int id, People value)
        {
            using (var http = new HttpClient())
            {
                System.Console.WriteLine("putting");
                var content = new StringContent(JsonConvert.SerializeObject(value));
                content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                var responseRequest = await http.PutAsync($"http://localhost:8080/api/people/{id}", content);
                return responseRequest.StatusCode;
            }
        }
    }
}