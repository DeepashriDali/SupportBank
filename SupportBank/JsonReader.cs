using System.Text.Json;
// using Newtonsoft.Json;

namespace SupportBank
{
    public class JsonReader: IFileReader
    { 
             public Bank ReadJsonFile(string path)
        {         
                Bank bank = new Bank();
                List<Account> accounts = new List<Account>();
         
                string filePath = File.ReadAllText(path);
                var lines = JsonSerializer.Deserialize<List<JsonTransaction>>(filePath);
                // var lines = JsonConvert.DeserializeObject<List<JsonTransaction>>(File.ReadAllText(path));
                      
                foreach(var line in lines)

                {
            
                  if (!accounts.Any(account=> account.Name == line.FromAccount.Name))
                    {
                        accounts.Add(new Account(line.FromAccount.Name));
                       
                    }
                       if (!accounts.Any(account=> account.Name == line.ToAccount.Name))
                    {
                        accounts.Add(new Account(line.ToAccount.Name));
                        Console.WriteLine("stage1");
                    }
                    Account sender = accounts.Find(account =>account.Name == line.FromAccount.Name);
                    Account receiver = accounts.Find(account =>account.Name == line.ToAccount.Name);

                    bank.Transactions.Add(new Transaction(
                    line.Date,
                    line.FromAccount,
                    line.ToAccount,
                    line.Narrative,
                    line.Amount  
                ));
                }
                return bank;
                  
        }
    }
}