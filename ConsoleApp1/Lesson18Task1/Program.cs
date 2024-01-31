namespace Lesson18Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread numbersThread = new Thread(PrintNumbers);
            numbersThread.Start();

            Thread lettersThread = new Thread(PrintLetters);
            lettersThread.Start();

            numbersThread.Join();
            lettersThread.Join();

        }

        static void PrintNumbers()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(100);
            }
        }

        static void PrintLetters()
        {
            for (char c = 'A'; c < 'K'; c++)
            {
                Console.WriteLine(c);
                Thread.Sleep(100);
            }
        }
    }
}