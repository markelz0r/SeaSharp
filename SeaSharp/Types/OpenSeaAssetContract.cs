using System.Text.Json.Serialization;
using SeaSharp.Types.Enums;

namespace SeaSharp.Types;

public class OpenSeaAssetContract
{
   public string Name { get; set; }
   public string Address { get; set; }
   public AssetContractType Type { get; set; }
   
   [JsonConverter(typeof(JsonStringEnumConverter))]
   public WyvernSchemaName SchemaName { get; set; }
   
   public int SellerFeeBasisPoints { get; set; }
   public int BuyerFeeBasisPoints { get; set; }
   public string Description { get; set; }
   public string TokenSymbol { get; set; }
   public string ImageUrl { get; set; }
   public object Stats { get; set; }
   public object[] Traits { get; set; }
   public string ExternalLink { get; set; }
   public string WikiLink { get; set; }
}