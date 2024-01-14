using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13Task2
{
    internal class CustomList<T> where T : IComparable<T>
    {
        private List<T> internalList = new List<T>();

        public void AddAndSort(T item)
        {
            internalList.Add(item);
            internalList.Sort();
            DisplayList();
        }

        public void DisplayList()
        {
            Console.WriteLine("Current List:");

            foreach (var item in internalList)
            {
                Console.WriteLine($"IdNumber: {((dynamic)item).IdNumber}");
            }

            Console.WriteLine();
        }
    }
}
