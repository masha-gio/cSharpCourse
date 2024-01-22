using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16Task5
{
    public static class EnumerableExtensions
    {
        public static T Median<T>(this IEnumerable<T> source)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            List<T> sortedList = source.OrderBy(x => x).ToList();
            int count = sortedList.Count;

            if (count == 0)
            {
                throw new InvalidOperationException("Sequence is empty.");
            }

            int middle = count / 2;

            return count % 2 == 0
                ? sortedList[middle - 1]
                : sortedList[middle];
        }
    }
}
