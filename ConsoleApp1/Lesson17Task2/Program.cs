namespace Lesson17Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string currentDirectory = Directory.GetCurrentDirectory();

            for (int i = 0; i < 20; i++)
            {
                string folderName = $"MyTestFolder{i}";
                string folderPath = Path.Combine(currentDirectory, folderName);

                Directory.CreateDirectory(folderPath);
                Console.WriteLine($"Directory added: {folderPath}");
            }

            for (int i = 0; i < 20; i++)
            {
                string folderName = $"MyTestFolder{i}";
                string folderPath = Path.Combine(currentDirectory, folderName);

                Directory.Delete(folderPath);
                Console.WriteLine($"Directory deleted: {folderPath}");
            }
        }
    }
}