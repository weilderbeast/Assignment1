using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Assignment1.Data.Models;

namespace Assignment1.Data.Persistence
{
    public class FileContextAsync
    {
        private IList<Family> _families;
        private IList<Adult> _adults;

        public FileContextAsync()
        {
            _families = new List<Family>();
            _adults = new List<Adult>();
        }

        public async Task<IList<Family>> GetFamiliesAsync()
        {
            var client = new HttpClient();
            var responseMessage = await client.GetAsync("https://localhost:5001/api/Family");

            if (!responseMessage.IsSuccessStatusCode)
                throw new Exception("Something went wrong, status code is " + responseMessage.StatusCode);
            var content = await responseMessage.Content.ReadAsStringAsync();
            _families = JsonSerializer.Deserialize<IList<Family>>(content, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });
            return _families;
        }

        public async Task<IList<Adult>> GetAdultsAsync()
        {
            var client = new HttpClient();
            var responseMessage = await client.GetAsync("https://localhost:5001/api/Adults");
            if (!responseMessage.IsSuccessStatusCode)
                throw new Exception("Something went wrong, status code is " + responseMessage.StatusCode);
            var content = await responseMessage.Content.ReadAsStringAsync();
            _adults = JsonSerializer.Deserialize<IList<Adult>>(content, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });
            return _adults;
        }

        public IList<Family> GetCachedFamilies()
        {
            return _families;
        }

        public IList<Adult> GetCachedAdults()
        {
            return _adults;
        }

        public async Task PostFamily(Family family)
        {
            var client = new HttpClient();
            var adultAsJson = JsonSerializer.Serialize(family);
            var content = new StringContent(
                adultAsJson,
                Encoding.UTF8,
                "application/json"
            );
            var response = await client.PostAsync("https://localhost:5001/api/Family", content);
            if(!response.IsSuccessStatusCode)
                throw new Exception($"Error: {response.StatusCode}, {response.ReasonPhrase}");
        }

        public async Task PostAdult(Adult adult)
        {
            var client = new HttpClient();
            var adultAsJson = JsonSerializer.Serialize(adult);
            var content = new StringContent(
                adultAsJson,
                Encoding.UTF8,
                "application/json"
                );
            var response = await client.PostAsync("https://localhost:5001/api/Adults", content);
            if(!response.IsSuccessStatusCode)
                throw new Exception($"Error: {response.StatusCode}, {response.ReasonPhrase}");
        }
    }
}