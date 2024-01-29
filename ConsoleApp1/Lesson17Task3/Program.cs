namespace Lesson17Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream stream = new FileStream("Test.txt", FileMode.OpenOrCreate, FileAccess.Write);

            using (StreamWriter writer = new StreamWriter(stream))
            {
                writer.WriteLine("Hi");
                writer.WriteLine(writer.NewLine);
                writer.WriteLine("Hi");
            }

            FileStream stream2 = new FileStream("Test.txt", FileMode.Open, FileAccess.Read);

            using (StreamReader reader = new StreamReader(stream2))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}