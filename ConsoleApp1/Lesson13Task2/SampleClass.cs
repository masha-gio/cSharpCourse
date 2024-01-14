using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13Task2
{
    internal class SampleClass : IComparable<SampleClass>
    {
        public int IdNumber { get; set; }

        public SampleClass(int idNumber)
        {
            IdNumber = idNumber;
        }

        public int CompareTo(SampleClass other)
        {
            return IdNumber.CompareTo(other.IdNumber);
        }
    }
}
