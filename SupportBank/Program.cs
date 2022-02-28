using NLog;
namespace SupportBank

{
    public class Program
    {
        public static void Main ( string[]args)
        {

            var config = new NLog.Config.LoggingConfiguration();

            // Targets where to log to: File and Console
            var logfile = new NLog.Targets.FileTarget("logfile") { FileName = @"C:\Training\SupportBank\SupportBank\log.log" };
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


            IFileReader loader = new IFileReader();
            Bank bank = loader.ReadFile(@"C:\Training\SupportBank\DodgyTransactions2015.csv");
          

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
