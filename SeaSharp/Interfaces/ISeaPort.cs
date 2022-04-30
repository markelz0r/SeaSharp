using SeaSharp.Types;

namespace SeaSharp;

public interface ISeaPort
{
   Task<OpenSeaAsset> GetAsset(string tokenAddress, string tokenId);
   Task<OpenSeaAssetBundle> GetBundle(string slug);
}