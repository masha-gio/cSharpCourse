using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8Task2
{
    abstract class Transport
    {
        public abstract Engine TransportEngine { get; }
        public abstract void Move();
    }
}
