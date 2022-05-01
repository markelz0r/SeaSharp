using System.Numerics;

namespace SeaSharp.Types.Wyvern;

public interface IOrder
{
   string Exchange { get; set; }
   string Maker { get; set; }
   string Taker { get; set; }
   BigInteger MakerRelayerFee { get; set; }
   BigInteger TakerRelayerFee { get; set; }
   BigInteger MakerProtocolFee { get; set; }
   BigInteger TakerProtocolFee { get; set; }
   string FeeRecipient { get; set; }
   int FeeMethod { get; set; }
   int Side { get; set; }
   int SaleKind { get; set; }
   string Target { get; set; }
   int HowToCall { get; set; }
   string Calldata { get; set; }
   string ReplacementPattern { get; set; }
   string StaticTraget { get; set; }
   string StaticExtradata { get; set; }
   string PaymentToken { get; set; }
   BigInteger BasePrice { get; set; }
   BigInteger Extra { get; set; }
   BigInteger ListingTime { get; set; }
   BigInteger ExpirationTime { get; set; }
   BigInteger Salt { get; set; }
}