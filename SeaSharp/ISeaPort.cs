using SeaSharp.Types;

namespace SeaSharp;

public interface ISeaPort
{
   OpenSeaAsset GetAsset(string tokenAddress, string tokenId);
}