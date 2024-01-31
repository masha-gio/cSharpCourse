namespace Lesson18Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputFile1 = "input1.txt";
            string inputFile2 = "input2.txt";
            string outputFile = "output.txt";

            File.WriteAllText(inputFile1, "File 1 content");
            File.WriteAllText(inputFile2, "File 2 content");

            object lockObject = new object();

            Parallel.Invoke(
                () => ReadAndWriteToFile(inputFile1, outputFile, lockObject),
                () => ReadAndWriteToFile(inputFile2, outputFile, lockObject)
            );

            Console.WriteLine("Job done. The result is passed to output.txt.");
        }

        static void ReadAndWriteToFile(string inputFile, string outputFile, object lockObject)
        {
            string content = File.ReadAllText(inputFile);

            Task.Delay(1000).Wait();

            lock (lockObject)
            {
                File.AppendAllText(outputFile, content + Environment.NewLine);            }

            Console.WriteLine($"File {inputFile} is read and written to {outputFile}. Thread: {Task.CurrentId}");
        }
    }
}