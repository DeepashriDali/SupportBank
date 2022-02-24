<<<<<<< HEAD
﻿using System;

=======
﻿
>>>>>>> 41ddc9650268bbf1ecb6db657130a521457d626c
namespace SupportBank

{
    public class Program
    {
        public static void Main ( string[]args)
        {
            if(args[0].ToLower() != "list")
            {
                return;
            }
            FileReader reader = new FileReader();
            Bank bank = reader.ReadFile(@"C:\Training\SupportBank\Transactions2014.csv");
            bank.PrintTransactions();

            if(args[1].ToLower() == "all")
            {
                bank.PrintTransactions();
                return;
            }

            decimal timLAccountBalance = bank.GetAccountBalance(args[1]);
            Console.WriteLine($"Balance of Tim L: £{timLAccountBalance}");
        }
    }

}
