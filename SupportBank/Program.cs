using System;

namespace SupportBank

{
    public class Program
    {
        public static void Main ( string[]args)
        {
            FileReader reader = new FileReader();
            Bank bank = reader.ReadFile(@"C:\Training\SupportBank\Transactions2014.csv");
            bank.PrintTransactions();

            decimal timLAccountBalance = bank.GetAccountBalance("Tim L");
            Console.WriteLine($"Balance of Tim L: £{timLAccountBalance}");
        }
    }

}

