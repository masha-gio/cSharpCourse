using System.Collections.Generic;
using System.Reflection.Emit;

namespace Lesson4Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[5];
            Random rand = new Random();

            Label:
            for (int i = 0; i < myArray.Length; i++) {
                myArray[i] = rand.Next(10);
            }

            Console.WriteLine(String.Join(", ", myArray));

            foreach (int item in myArray)
            {
                if (item == 0)
                {
                    Console.WriteLine("One of the numbers equal 0, generating new array");
                    goto Label;
                }
            }
        }
    }
}