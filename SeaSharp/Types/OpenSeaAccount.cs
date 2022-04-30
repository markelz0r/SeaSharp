namespace SeaSharp.Types;

public class OpenSeaAccount
{
   public string Address { get; set; }
   public string Config { get; set; }
   public string ProfileImgUrl { get; set; }
   public OpenSeaUser User { get; set; }
}