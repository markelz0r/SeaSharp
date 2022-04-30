using System.Text.Json;
using SeaSharp.Types;

namespace SeaSharp;

public static class JsonParser
{
   private static readonly JsonSerializerOptions Options = new()
   {
      PropertyNamingPolicy = new LowerCaseNamingPolicy()
   };
   public static OpenSeaAsset? GetAssetFromJson(string json)
   {
      throw new NotImplementedException();
   }
   
   public static OpenSeaAssetBundle? GetBundleFromJson(string json)
   {
      return JsonSerializer.Deserialize<OpenSeaAssetBundle>(json, Options);
   }
}