using System.Numerics;
using SeaSharp.Types.Wyvern;

namespace SeaSharp.Types;

public class Order : IECSignature, IUnsignedOrder
{
   public Order()
   {
      // TODO Probably needs a custom converter due to complexity
      throw new NotImplementedException();
   }
   
   public BigInteger CreatedTime { get; set; }
   public BigInteger CurrentPrice { get; set; }
   public BigInteger CurrentBounty { get; set; }
   public OpenSeaAccount MarketAccount { get; set; }
   public OpenSeaAccount TakerAccount { get; set; }
   public OpenSeaFungibleToken PaymentTokenContract { get; set; }
   public OpenSeaAccount FeeRecipientAccount { get; set; }
   public bool CancelledOrFinalized { get; set; }
   public bool MarkedInvalid { get; set; }
   public OpenSeaAsset Asset { get; set; }
   public OpenSeaAssetBundle AssetBundle { get; set; }
   public int Nonce { get; set; }
   
   // IECSignature
   public int V { get; set; }
   public string R { get; set; }
   public string S { get; set; }
   
   // IUnsignedOrder
   public string Hash { get; set; }
   
   // IOrder (Wyvern)
   public string Exchange { get; set; }
   public string Maker { get; set; }
   public string Taker { get; set; }
   public BigInteger MakerRelayerFee { get; set; }
   public BigInteger TakerRelayerFee { get; set; }
   public BigInteger MakerProtocolFee { get; set; }
   public BigInteger TakerProtocolFee { get; set; }
   public string FeeRecipient { get; set; }
   public int FeeMethod { get; set; }
   public int Side { get; set; }
   public int SaleKind { get; set; }
   public string Target { get; set; }
   public int HowToCall { get; set; }
   public string Calldata { get; set; }
   public string ReplacementPattern { get; set; }
   public string StaticTraget { get; set; }
   public string StaticExtradata { get; set; }
   public string PaymentToken { get; set; }
   public BigInteger BasePrice { get; set; }
   public BigInteger Extra { get; set; }
   public BigInteger ListingTime { get; set; }
   public BigInteger ExpirationTime { get; set; }
   public BigInteger Salt { get; set; }
}