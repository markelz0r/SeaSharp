namespace SeaSharp.Types.Wyvern;

public interface IECSignature
{
   public int V { get; set; }
   public string R { get; set; }
   public string S { get; set; }
}