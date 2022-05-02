using System.Text.Json.Serialization;
using SeaSharp.Json.Converters;
using SeaSharp.Types.Enums;

namespace SeaSharp.Types;

public class AssetEvent
{
   [JsonConverter(typeof(AssetEventTypeJsonConverter))]
   public AssetEventType EventType { get; set; }
   public DateTime EventTimestamp { get; set; }
   
   [JsonConverter(typeof(AuctionTypeJsonConverter))]
   public AuctionType AuctionType { get; set; }
   public string TotalPrice { get; set; }
   public Transaction Transaction { get; set; }
   public OpenSeaFungibleToken PaymentToken { get; set; }
}