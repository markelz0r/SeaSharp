using System.Text.Json.Serialization;

namespace SeaSharp.Types;

public class OpenSeaAssetBundle
{
   public OpenSeaAccount Maker { get; set; }
   public List<OpenSeaAsset> Assets { get; set; }
   public string Name { get; set; }
   public string Slug { get; set; }
   public string Permalink { get; set; }
}