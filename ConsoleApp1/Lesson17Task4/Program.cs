using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Lesson17Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyItem myItem = new MyItem
            {
                Age = 5,
                Name = "Book"
            };

            FileStream stream = new FileStream("MyItems.json", FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);

            string stringJsonValue = JsonConvert.SerializeObject(myItem, Formatting.Indented);

            writer.WriteLine(stringJsonValue);

            writer.Close();
            stream.Close();            
        }
    }
}