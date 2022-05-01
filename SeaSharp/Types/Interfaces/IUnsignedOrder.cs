namespace SeaSharp.Types.Interfaces;

public interface IUnsignedOrder : IUnhashedOrder
{
   string Hash { get; set; }
}