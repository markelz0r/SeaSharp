namespace SeaSharp.Types;

public interface IUnsignedOrder : IUnhashedOrder
{
   string Hash { get; set; }
}