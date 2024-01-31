namespace Lesson18Task2
{
    internal class Program
    {
        static int sharedVariable = 0;
        static Mutex mutex = new Mutex();
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++) {
                Thread thread = new Thread(incrementSharedVariable);
                thread.Start();
            }

            Console.ReadLine();
        }
        static void incrementSharedVariable() {
        for(int i = 0; i < 5; i++)
            {
                mutex.WaitOne();
                try
                {
                    int currentValue = sharedVariable;
                    Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId}: Current Value: {currentValue}");
                    Thread.Sleep(100);
                    sharedVariable = currentValue + 1;
                    Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId}: Updated Value: {sharedVariable}");
                }
                finally
                {
                    mutex.ReleaseMutex();
                }
                Thread.Sleep(100);
            }
        }
    }
}