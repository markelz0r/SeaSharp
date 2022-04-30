using System.Text.Json.Serialization;

namespace SeaSharp.Types;

public class OpenSeaAccount
{
   public string Address { get; set; }
   public string Config { get; set; }
   
   [JsonPropertyName("profile_img_url")]
   public string ProfileImgUrl { get; set; }
   
   public OpenSeaUser User { get; set; }
}