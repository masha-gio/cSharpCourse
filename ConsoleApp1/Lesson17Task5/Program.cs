using System.IO;
using System.Text;

namespace Lesson17Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "test.txt";
            string initialContent = "Hi, my name is tist file";
            string searchString = "tist";
            string replacementString = "test";

            File.WriteAllText(filePath, initialContent);

            using (FileStream fileStram = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                using (StreamReader reader = new StreamReader(fileStram))
                {
                    string currentFileContent = reader.ReadToEnd();    
                    int index = currentFileContent.IndexOf(searchString);
                    if (index != -1)
                    {
                        fileStram.Position = index;

                        byte[] replacementBytes = Encoding.UTF8.GetBytes(replacementString);
                        fileStram.Write(replacementBytes, 0, replacementBytes.Length);
                    }
                    else
                    {
                        Console.WriteLine("String not found");
                    }
                }


                using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        string changedContent = reader.ReadToEnd();
                        Console.WriteLine(changedContent);
                    }
                }
            }
        }
    }
}