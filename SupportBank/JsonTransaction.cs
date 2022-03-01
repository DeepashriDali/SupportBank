namespace SupportBank
{

   public class JsonTransaction
 {
    public DateTime Date {get; set;}
    public Account FromAccount {get; set;}
    public Account ToAccount {get; set;}
    public string Narrative {get; set;}
    public decimal Amount {get; set;}
 

    public JsonTransaction(DateTime date, Account fromAccount, Account toAccount, string narrative, decimal amount)
    {
        Date = date;
        FromAccount = fromAccount;
        ToAccount = toAccount;
        Narrative = narrative;
        Amount = amount;
    }
public override string ToString()
    {
        return $" {Date}  Amount: {Amount} From:{FromAccount} To: {ToAccount} Ref: {Narrative} ";
    }
 }
} 