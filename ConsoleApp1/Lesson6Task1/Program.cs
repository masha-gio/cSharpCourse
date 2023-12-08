using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        string[] myArray = { "apple", "banana", "kiwi" };
        string valueToAdd = "plum";

        string[] result = AddValueToArray(myArray, valueToAdd);

        if (result != null)
        {
            Console.WriteLine("Array after");
            foreach (string s in result)
            {
                Console.WriteLine(s);
            }
        }
        else
        {
            Console.WriteLine("Invalid parameters");
        }
    }
    static string[] AddValueToArray(string[] array, string value)
    {
        if (array == null || string.IsNullOrEmpty(value))
        {
            return null;
        }

        if (Array.Exists(array, element => element.Equals(value, StringComparison.OrdinalIgnoreCase)))
        {
            Console.WriteLine($"Array already has value {value}. Returning array");
            return array;
        }

        // check if there is space
        int nullIndex = Array.IndexOf(array, null);
        if (nullIndex != -1)
        {
            array[nullIndex] = value;
            Console.WriteLine($"Value {value} added to the array");
            return array;
        }
        else
        {
            string[] newArray = new string[array.Length + 1];
            Array.Copy(array, newArray, array.Length);
            newArray[array.Length] = value;
            Console.WriteLine($"Array was extended and value {value} is added to the array");
            return newArray;
        }
    }
}