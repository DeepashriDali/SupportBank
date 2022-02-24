namespace SupportBank
{
    public class Transaction
    {
        public DateTime Date { get; set;}
        public string Sender { get; set; }
        public string Receiver { get; set; }

        public string Narrative { get; set ;}

        public decimal Amount { get; set; }

         public Transaction(DateTime date, string sender, string receiver, string narrative, decimal amount)
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