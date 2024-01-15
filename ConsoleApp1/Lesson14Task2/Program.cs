namespace Lesson14Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                try
                {
                    Console.WriteLine("Input first number (0-255): ");
                    int num1 = GetNumberInput();

                    if (num1 < 0 || num1 > 255)
                    {
                        throw new ArgumentOutOfRangeException("Number should be in the 0 to 255 range.");
                    }

                    Console.WriteLine("Input second number (0-255): ");
                    int num2 = GetNumberInput();

                    if (num2 < 0 || num2 > 255)
                    {
                        throw new ArgumentOutOfRangeException("Number should be in the 0 to 255 range.");
                    }

                    double result = DivideNumbers(num1, num2);
                    Console.WriteLine($"The result of devision: {result}");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error in the input. Enter integer.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Overflow error. Number should be in the 0 to 255 range.");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Devision error. Input second number greater than 0.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
        static int GetNumberInput()
        {
            string input = Console.ReadLine();
            return int.Parse(input);
        }

        static double DivideNumbers(int num1, int num2)
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException();
            }

            return (double)num1 / num2;
        }
    }
}