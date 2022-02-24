﻿
namespace SupportBank

{
    public class Program
    {
        public static void Main ( string[]args)
        {
            // if(args[0].ToLower() != "list")
            // {
            //     return;
            // }
            FileReader reader = new FileReader();
            Bank bank = reader.ReadFile(@"C:\Training\11-SupportBank\Transactions2014.csv");
            bank.PrintTransactions();
            bank.GetAccountBalance("Tim L");
            // if(args[1].ToLower() == "all")
            // {
            //     bank.PrintTransactions();
            //     return;
            // }

            // decimal timLAccountBalance = bank.GetAccountBalance(args[1]);
            // Console.WriteLine($"Balance of Tim L: £{timLAccountBalance}");
        }
    }

}
