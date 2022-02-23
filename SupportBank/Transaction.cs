namespace SupportBank
{
    public class Transaction
    {
        DateTime Date { get; set;}
        string Sender { get; set; }
        string? Receiver { get; set; }

        string Narrative { get; set ;}

        double Amount { get; set; }

         public Transaction(DateTime date, string sender, string reveiver, string narrative, double amount)
        {
        Date = date;
        Sender = sender;
        Receiver = Receiver;
        Narrative = narrative;
        Amount = amount;
        }
    }
}