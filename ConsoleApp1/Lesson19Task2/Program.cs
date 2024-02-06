using System;
using System.Threading.Tasks;

namespace Lesson19Task2
{
    internal class Program
    {
        static async Task Main()
        {
            AsyncMethods asyncMethods = new AsyncMethods();
            int time = 3000;

            await asyncMethods.DelayedHelloAsync(time);

            Console.WriteLine("Main method using awaiter completed");

            await asyncMethods.DelayedHelloAsync(time).ContinueWith(task =>
            {
                Console.WriteLine("Hello again");
            });
             
            Console.WriteLine("Main method using ContinueWith completed");

        }
    }
}