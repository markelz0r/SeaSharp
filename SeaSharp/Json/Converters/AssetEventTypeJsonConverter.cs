using System.Text.Json;
using System.Text.Json.Serialization;
using SeaSharp.Types;

namespace SeaSharp.Json.Converters;

public class AssetEventTypeJsonConverter : JsonConverter<AssetEventType>
{
   public override AssetEventType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
   {
      var value = reader.GetString();
      return value switch
      {
         "created" => AssetEventType.AuctionCreated,
         "successful" => AssetEventType.AuctionSuccessful,
         "cancelled" => AssetEventType.AuctionCancelled,
         "offer_entered" => AssetEventType.OfferEntered,
         "bid_entered" => AssetEventType.BidEntered,
         "bid_withdraw" => AssetEventType.BidWithdraw,
         "transfer" => AssetEventType.AssetTransfer,
         "approve" => AssetEventType.AssetApprove,
         "composition_created" => AssetEventType.CompositionCreated,
         "custom" => AssetEventType.Custom,
         "payout" => AssetEventType.Payout,
         _ => throw new ArgumentOutOfRangeException()
      };
   }

   public override void Write(Utf8JsonWriter writer, AssetEventType value, JsonSerializerOptions options)
   {
      throw new NotImplementedException();
   }
}