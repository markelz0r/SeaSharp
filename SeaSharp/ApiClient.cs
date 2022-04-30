using System.Text.Json;
using SeaSharp.Types;

namespace SeaSharp;

public class ApiClient
{
   private static readonly HttpClient Client = new();

   public ApiClient(string apiKey)
   {
      Client.DefaultRequestHeaders.Add("X-API-KEY", apiKey);
   }

   public static async Task<T> Get<T>(string url)
   {
      var response = await Client.GetAsync(CommonValues.API_BASE_MAINNET+url);
      response.EnsureSuccessStatusCode();
      var responseString = await response.Content.ReadAsStringAsync();
      
      var parsedObject = JsonSerializer.Deserialize<T>(responseString);
      
      if (parsedObject == null)
         throw new InvalidOperationException();

      return parsedObject;
   }
}