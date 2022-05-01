namespace SeaSharp.Types;

public class Transaction
{
   public OpenSeaAccount FromAccount { get; set; }
   public OpenSeaAccount ToAccount { get; set; }
   public DateTime CreatedDate { get; set; }
   public DateTime ModifiedDate { get; set; }
   public string TransactionHash { get; set; }
   public string TransactionIndex { get; set; }
   public string BlockNumber { get; set; }
   public string BlockHash { get; set; }
   public DateTime Timestamp { get; set; }
}