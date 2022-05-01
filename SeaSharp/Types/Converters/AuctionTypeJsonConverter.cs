﻿using System.Text.Json;
using System.Text.Json.Serialization;

namespace SeaSharp.Types.Converters;

public class AuctionTypeJsonConverter : JsonConverter<AuctionType>
{
   public override AuctionType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
   {
      var value = reader.GetString();
      return value switch
      {
         "dutch" => AuctionType.Dutch,
         "english" => AuctionType.English,
         "min_price" => AuctionType.MinPrice,
         _ => throw new ArgumentOutOfRangeException()
      };
   }

   public override void Write(Utf8JsonWriter writer, AuctionType value, JsonSerializerOptions options)
   {
      throw new NotImplementedException();
   }
}