
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
            Bank bank = reader.ReadFile(@"C:\Training\SupportBank\Transactions2014.csv");
            bank.PrintTransactions();

            // if(args[1].ToLower() == "all")
            // {
            //     bank.PrintTransactions();
            //     return;
            // }
            foreach(var account in bank.Accounts)
            {
                Console.WriteLine(account);
            }
            decimal balance = bank.GetAccountBalance(args[1]);
            Console.WriteLine($"Balance for {args[1]}: £{balance}");
        }
    }

}
