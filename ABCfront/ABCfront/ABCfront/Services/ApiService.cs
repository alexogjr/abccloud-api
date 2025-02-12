using System.Text.Json;
using ABCfront.Models;

namespace ABCfront.Services
{
    public class ApiService
    {
        private readonly HttpClient _httpClient;

        public ApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        // desserialização do json
        public async Task<Usuario> GetDataFromApiAsync(string url)
        {
            var response = await _httpClient.GetStringAsync(url);
            return JsonSerializer.Deserialize<Usuario>(response, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }
    }
}
