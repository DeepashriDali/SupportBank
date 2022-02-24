namespace SupportBank
{
    public class Transaction
    {
        public DateTime Date { get; set;}
        public Account Sender { get; set; }
        public Account Receiver { get; set; }

        public string Narrative { get; set ;}

        public decimal Amount { get; set; }

         public Transaction(DateTime date, Account sender, Account receiver, string narrative, decimal amount)
        {
        Date = date;
        Sender = sender;
        Receiver = receiver;
        Narrative = narrative;
        Amount = amount;
        }
        public override string ToString()
        {
            return $"{Date}: £{Amount} from {Sender} to {Receiver} for {Narrative}";
        }
    }
}