using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Lesson4Task4
{
    internal class Program


    {
        static void Main(string[] args)


        {
            var isIncome = decimal.TryParse(Console.ReadLine(), out decimal income);
            if (isIncome)
            {
                decimal tax;
                bool success = CalculateIncomeTax(income, out tax);

                if (success)
                {
                    Console.WriteLine($"The income tax is: {tax}");
                }
                else
                {
                    Console.WriteLine("Could not calculate the income tax");
                }
            }
            else
            {
                Console.WriteLine("Income is not a valid number");
            }

            static bool CalculateIncomeTax(decimal income, out decimal tax)
            {
                decimal taxRate = 0.01m;

                if (income < 0)
                {
                    tax = 0;
                    return false;
                }

                tax = income * taxRate;
                return true;
            }
        }
    }
}