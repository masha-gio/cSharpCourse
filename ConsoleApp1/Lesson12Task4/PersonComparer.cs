using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12Task4
{
    internal class PersonComparer : IComparer<Person>
    {
        public int Compare(Person? x, Person? y)
        {
            int GenderComparison = String.Compare(x.Gender, y.Gender, StringComparison.Ordinal);
            if (GenderComparison != 0)
            {
                return GenderComparison;
            }
            return x.Age.CompareTo(y.Age);
        }
    }
}
