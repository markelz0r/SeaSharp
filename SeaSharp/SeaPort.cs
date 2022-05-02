using System.Text.Json;
using SeaSharp.Json;
using SeaSharp.Types;

namespace SeaSharp;

public class SeaPort : ISeaPort
{
   private readonly ApiClient _apiClient;

   public SeaPort()
   {
      _apiClient = new ApiClient("");
   }

   /// <summary>
   /// Fetch an asset from the API, throwing if none is found
   /// </summary>
   /// <param name="tokenAddress">Address of the asset's contract</param>
   /// <param name="tokenId">The asset's token ID, or null if ERC-20</param>
   /// <returns>OpenSeaAsset if available</returns>
   public async Task<OpenSeaAsset> GetAsset(string tokenAddress, string tokenId)
   {
      var tokenString = tokenId != string.Empty ? tokenId : "0";
      var url = $"{CommonValues.API_PATH}/asset/{tokenAddress}/{tokenString}";
      var options = new JsonSerializerOptions()
      {
         PropertyNamingPolicy = new LowerCaseNamingPolicy()
      };
      
      var response = await _apiClient.Get(url);
      var asset = JsonSerializer.Deserialize<OpenSeaAsset>(response, options);

      if (asset == null)
         throw new Exception();

      return asset;
   }

   /// <summary>
   /// Fetch a bundle from the API, return null if it isn't found
   /// </summary>
   /// <param name="slug">The bundle's identifier</param>
   /// <returns>OpenSeaAssetBundle if exists</returns>
   public async Task<OpenSeaAssetBundle> GetBundle(string slug)
   {
      var url = $"{CommonValues.API_PATH}/bundle/{slug}";
      var options = new JsonSerializerOptions()
      {
         PropertyNamingPolicy = new LowerCaseNamingPolicy()
      };

      var response = await _apiClient.Get(url);
      var bundle = JsonSerializer.Deserialize<OpenSeaAssetBundle>(response, options);
      
      if (bundle == null)
         throw new Exception();

      return bundle;
   }
}