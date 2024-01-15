using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14Task3
{
    public class ExampleClass
    {
        public void ProcessString(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new EmptyStringException();
            }

            Console.WriteLine($"Processing string: {input}");
        }
    }
}
