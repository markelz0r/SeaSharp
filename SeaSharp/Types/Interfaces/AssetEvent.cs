﻿using System.Text.Json.Serialization;
using SeaSharp.Json.Converters;
using SeaSharp.Types.Enums;

namespace SeaSharp.Types;

public interface AssetEvent
{
   [JsonConverter(typeof(AssetEventTypeJsonConverter))]
   public AssetEventType EventType { get; set; }
   public DateTime EventTimeStamp { get; set; }
   
   [JsonConverter(typeof(AuctionTypeJsonConverter))]
   public AuctionType AuctionType { get; set; }
   public string TotalPrice { get; set; }
   public Transaction Transaction { get; set; }
   public OpenSeaFungibleToken PaymentToken { get; set; }
}