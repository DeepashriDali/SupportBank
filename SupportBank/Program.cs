

namespace SupportBank

{
    public class Program
    {
        public static void Main ( string[]args)
        {
            Transactions transactions = new Transactions();

            transactions.Readfile();

            // Person person = new Person(transactions.Readfile(Sender), 23,4);

            // Console.WriteLine(person.PersonName);
        }
    }

}

