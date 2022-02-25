namespace SupportBank
{
    public class Bank
    {
        public List<Transaction> Transactions {get; set;}

        public List<Account> Accounts {
            get
            {
                List<Account> account = new List<Account>();
                foreach (var transaction in Transactions)
                {
                    if(!account.Any(account =>account.Name == transaction.Sender.Name))
                    {
                        account.Add(transaction.Sender);
                    }
                     if(!account.Any(account =>account.Name == transaction.Receiver.Name))
                    {
                        account.Add(transaction.Receiver);
                    }
                }
                return account;
            }
        }
        public Bank ()

        {
           Transactions = new List<Transaction>();
        }

        public void PrintTransactions()
        {
            foreach(var transaction in Transactions)
            {
            Console.WriteLine(transaction);
            }
        }

        public void GetAccountBalance(string name)
        {
            if(!Accounts.Any(account => account.Name == name))
            {
                throw new ArgumentOutOfRangeException("Given name does not exist");
            }

            Account account = Accounts.Find(a => a.Name == name);
            decimal result = 0;

            foreach(var transaction in Transactions)
            {
                if(transaction.Sender.Name == account.Name)
                {
                    result -= transaction.Amount;
                }
                if(transaction.Receiver.Name == account.Name)
                {
                    result += transaction.Amount;
                }
            }
            Console.WriteLine($" Account Balance of {name} is: {result}");
       
        }
    }
}
