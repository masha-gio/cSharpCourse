using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lesson19Task2
{
    internal class AsyncMethods
    {
       public async Task DelayedHelloAsync(int time)
        {
            await Task.Delay(time);
            Console.WriteLine("Hello from callback");
        }
    }
}
