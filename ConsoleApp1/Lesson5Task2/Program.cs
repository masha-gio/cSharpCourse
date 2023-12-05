namespace Lesson5Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            var isNumber = int.TryParse(Console.ReadLine(), out int number);
            Console.WriteLine("PLease enter maximum value");
            var isMaxValue = int.TryParse(Console.ReadLine(), out int maxValue);
            if(isNumber && isMaxValue) {
            PrintTimeTable(number, maxValue);
            }
            else
            {
                Console.WriteLine("One of the entries is not a valid number");
            }
            
        }

        static void PrintTimeTable(int number, int maxValue)
        {
            Console.WriteLine($"Timetable for number {number}:");
            for (int i = 0; i <= maxValue; i++) {
                int result = i * number;
                Console.WriteLine($"{ number} * { i} = { result}");
            }
        }
    }
}