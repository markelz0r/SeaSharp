using SeaSharp.Types;

namespace SeaSharp;

public class SeaPort : ISeaPort
{
   private readonly ApiClient _apiClient;

   public SeaPort()
   {
      _apiClient = new ApiClient("");
   }

   public OpenSeaAsset GetAsset(string tokenAddress, string tokenId)
   {
      var tokenString = tokenId != string.Empty ? tokenId : "0";
      var url = $"{CommonValues.API_PATH}/asset/${tokenAddress}/{tokenString}";

      var response = ApiClient.Get<OpenSeaAsset>(url);
      return response.Result;
   }
}