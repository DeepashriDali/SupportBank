using NLog;

namespace SupportBank

{
    public class Program
    {
        public static void Main ( string[]args)
        {

            var config = new NLog.Config.LoggingConfiguration();

            // Targets where to log to: File and Console
            var logfile = new NLog.Targets.FileTarget("logfile") { FileName = @"C:\Training\11-SupportBank\SupportBank\log.log" };
            var logconsole = new NLog.Targets.ConsoleTarget("logconsole");
            
            // Rules for mapping loggers to targets            
            config.AddRule(LogLevel.Info, LogLevel.Fatal, logconsole);
            config.AddRule(LogLevel.Debug, LogLevel.Fatal, logfile);
            
            // Apply config           
            NLog.LogManager.Configuration = config;
            if (args[0].ToLower() != "list")
            {
                return;
            }


            // CsvReader loader = new CsvReader();
            // Bank bank = loader.ReadCsvFile(@"C:\Training\11-SupportBank\Transactions2014.csv");
            JsonReader loader1 = new JsonReader();
            Bank bank = loader1.ReadJsonFile(@"C:\Training\11-SupportBank\Transactions2013.json");

            if (args[1].ToLower() == "all")
            {
                
                bank.PrintTransactions();
            }
            else 
            {
                bank.GetAccountBalance(args[1]);
            }
           
        }
    }

}