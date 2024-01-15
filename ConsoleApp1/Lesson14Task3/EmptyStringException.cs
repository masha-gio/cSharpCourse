using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14Task3
{
    public class EmptyStringException : Exception
    {
        public EmptyStringException() : base("Empty string in the input")
        {
        }
    }
}
