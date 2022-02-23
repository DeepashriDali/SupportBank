

namespace SupportBank
{

    public class Transactions
    {

        public void Readfile(){

            string path = @"C:\Training\11-SupportBank\Transactions2014.csv";
            string[] lines = System.IO.File.ReadAllLines(path);
            foreach(string line in lines)
            {
                string[] columns = line.Split(',');
                string Date = columns[0];
                string Sender = columns[1];
                string Receiever = columns[2];
                string Narrative = columns[3];
                string Amount = columns[4];
             
                // foreach (string column in columns) 
                // {
                Console.WriteLine(Amount);
                // }
            }
        }
            
    }
}

