using System.Text.Json.Serialization;
using SeaSharp.Json.Converters;

namespace SeaSharp.Types;

public class OpenSeaFungibleToken : Token
{
   public string ImageUrl { get; set; }
   
   [JsonConverter(typeof(StringDecimalJsonConverter))]
   public decimal EthPrice { get; set; }
   
   [JsonConverter(typeof(StringDecimalJsonConverter))]
   public decimal UsdPrice { get; set; }
}