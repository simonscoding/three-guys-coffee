using Services.Recipies.Models;


using Microsoft.Extensions.Logging;
using System.Text.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace Services.Recipies.Client
{
    public class RecipieClient
    {
        private readonly ILogger<RecipieClient> _logger;
        private readonly HttpClient _httpClient;

        public RecipieClient(ILogger<RecipieClient> logger, HttpClient httpClient)
        {
            _logger = logger;
            _httpClient = httpClient;
        }

        public async Task<RecipeApiResponse?> GetRecipies()
        {
            try
            {
                var response = await _httpClient.GetAsync("https://dummyjson.com/recipes");
                response.EnsureSuccessStatusCode();

                var json = await response.Content.ReadAsStringAsync();

                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                var result = JsonSerializer.Deserialize<RecipeApiResponse>(json, options);
                return result;
            }
            catch (HttpRequestException ex)
            {
                _logger.LogError(ex, "Error fetching recipes");
                throw;
            }
        }
    }
}
