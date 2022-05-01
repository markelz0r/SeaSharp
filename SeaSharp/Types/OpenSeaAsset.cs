using System.Text.Json.Nodes;

namespace SeaSharp.Types;

public class OpenSeaAsset
{
   public OpenSeaAssetContract AssetContract { get; set; }
   public OpenSeaCollection Collection { get; set; }
   public string Name { get; set; }
   public string Description { get; set; }
   public OpenSeaAccount Owner { get; set; }
   public List<Order> Orders { get; set; }
   public List<Order> BuyOrders { get; set; }
   public List<Order> SellOrders { get; set; }
   public bool IsPresale { get; set; }
   public string ImageUrl { get; set; }
   public string ImagePreviewUrl { get; set; }
   public string ImageUrlOriginal { get; set; }
   public string ImageUrlThumbnail { get; set; }
   public string Permalink { get; set; }
   public string ExternalLink { get; set; }
   public JsonObject[] Trairs { get; set; }
   public int NumSales { get; set; }
   public AssetEvent LastSale { get; set; }
   public string BackgroundColor { get; set; }
   public string TransferFee { get; set; }
   public OpenSeaFungibleToken TransferFeePaymentToken { get; set; }
   
   
}