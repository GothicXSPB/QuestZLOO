using System.IO;
using System.Text.Json;


namespace QuestZLOO
{
    public class Program
    {
        static async void Main(string[] args)
        {
            string path = "Bike.txt";

            Bike bike = new Bike("stels", "black", "steel");

            using (StreamWriter writer = new StreamWriter(path, false))
            {
                await writer.WriteLineAsync(Bike);
            }
        }

    }
}
