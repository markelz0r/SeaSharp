namespace SeaSharp.Types;

public class OpenSeaCollection
{
   public string Name { get; set; }
   public string Slug { get; set; }
   public IEnumerable<string> Editors { get; set; }
   public bool Hidden { get; set; }
   public bool Featured { get; set; }
   public DateTime CreatedDate { get; set; }
   public string Description { get; set; }
   public string ImageUrl { get; set; }
   public string LargeImageUrl { get; set; }
   public string FeaturedImageUrl { get; set; }
   public object Stats { get; set; }
   public object DisplayData { get; set; }
   public OpenSeaFungibleToken[] PaymentTokens { get; set; }
   public string PayoutAddress { get; set; }
   public OpenSeaTraitStats TraitStats { get; set; }
   public string ExternalLink { get; set; }
   public string WikiLink { get; set; }
}