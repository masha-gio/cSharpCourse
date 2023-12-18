using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8Task3
{
    internal static class ArrayExtension
    {
        public static int FindMaxValue(this int[] array)
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentNullException("Array can not be null or empty");
            }
            return array.Max();
        }
    }
}

