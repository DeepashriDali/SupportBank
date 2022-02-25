using NLog;
using Newtonsoft.Json;
namespace SupportBank
{

    public class JsonReader : IFileReader
    {

    private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

     public Transaction ReadFile(string path)
     {
         var file = JsonConvert.DeserializeObject<List<Transaction>>(File.ReadAllText(path));
     }
    }

}