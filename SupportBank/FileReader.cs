namespace SupportBank
{
    public class FileReader
    {
        public Bank ReadFile(string path)
        {
            
             using (StreamReader sr = new StreamReader(path))
            {
                sr.ReadLine();
               
                Bank bank = new Bank();
<<<<<<< HEAD
=======
                List<Account> accounts = new List<Account>();
>>>>>>> 41ddc9650268bbf1ecb6db657130a521457d626c
                
                string? line;

                while ((line = sr.ReadLine()) != null)
                {
                    string[] splitLine = line.Split(",");
<<<<<<< HEAD

                    bank.Transactions.Add(new Transaction(
                    DateTime.Parse(splitLine[0]),
                    splitLine[1],
                    splitLine[2],
=======
                    if (!accounts.Any(account=> account.Name == splitLine[1]))
                    {
                        accounts.Add(new Account(splitLine[1]));
                    }
                       if (!accounts.Any(account=> account.Name == splitLine[2]))
                    {
                        accounts.Add(new Account(splitLine[2]));
                    }
                    Account from = accounts.Find(account =>account.Name == splitLine[1]);
                    Account to = accounts.Find(account =>account.Name == splitLine[2]);

                    bank.Transactions.Add(new Transaction(
                    DateTime.Parse(splitLine[0]),
                    from,
                    to,
>>>>>>> 41ddc9650268bbf1ecb6db657130a521457d626c
                    splitLine[3],
                    decimal.Parse(splitLine[4])  
                ));
                }
                return bank;
            }
            
        }
    }
}