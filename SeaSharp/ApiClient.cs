using System.Text.Json;
using SeaSharp.Types;

namespace SeaSharp;

public class ApiClient
{
   private readonly HttpClient _client = new();

   public ApiClient(string apiKey)
   {
      _client.DefaultRequestHeaders.Add("X-API-KEY", apiKey);
   }

   public async Task<string> Get<T>(string url)
   {
      var response = await _client.GetAsync(CommonValues.API_BASE_MAINNET+url);
      response.EnsureSuccessStatusCode();
      return await response.Content.ReadAsStringAsync();
   }
}