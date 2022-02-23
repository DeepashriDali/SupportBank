

namespace SupportBank
{

    public class Transactions
    {

        public void Readfile(){
            

            string path = @"C:\Training\11-SupportBank\Transactions2014.csv";
            string[] lines = System.IO.File.ReadAllLines(path);
            foreach(string line in lines)
            {
                // string[] columns = line.Split(',');
                // foreach (string column in columns) 
                {
                Console.WriteLine(line);
                }
            }
        }
            
    }
}

