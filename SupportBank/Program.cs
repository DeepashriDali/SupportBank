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

            FileReader loader = new FileReader();
            Bank bank = loader.ReadFile(@"C:\Training\SupportBank\Transactions2014.csv");

            if (args[1].ToLower() == "all")
            {
                
                return;
            }
            bank.PrintTransactions();
            bank.GetAccountBalance("Tim L");
            // Console.WriteLine($"Balance for {args[1]}: £{balance}");
        }
    }

}
