using NLog;
namespace SupportBank
{
    public class FileReader
    {

        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();
       
        public Bank ReadFile(string path)
        {
            
             using (StreamReader sr = new StreamReader(path))
            {
                sr.ReadLine();
               
                Bank bank = new Bank();
                List<Account> accounts = new List<Account>();
                
                string? line;


                while ((line = sr.ReadLine()) != null)
                {
                    string[] splitLine = line.Split(",");
                    if (!accounts.Any(account=> account.Name == splitLine[1]))
                    {
                        accounts.Add(new Account(splitLine[1]));
                    }
                       if (!accounts.Any(account=> account.Name == splitLine[2]))
                    {
                        accounts.Add(new Account(splitLine[2]));
                    }
                    Account sender = accounts.Find(account =>account.Name == splitLine[1]);
                    Account receiver = accounts.Find(account =>account.Name == splitLine[2]);

                    try 
                    {
                        var date = DateTime.Parse(splitLine[0]);
                    }
                    catch(FormatException e)
                    {
                        throw new FormatException("Date was unable to parse", e);
                    }

                    Logger.Info($"Loading line {line} from file {path}");

                    bank.Transactions.Add(new Transaction(
                    DateTime.Parse(splitLine[0]),
                    sender,
                    receiver,
                    splitLine[3],
                    decimal.Parse(splitLine[4])  
                ));
                }
                return bank;
            }
            
        }
    }
}