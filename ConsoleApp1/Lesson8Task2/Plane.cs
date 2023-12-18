using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8Task2
{
    internal class Plane : Transport
    {
        public override Engine TransportEngine { get; } = new Engine();

        public override void Move()
        {
            Console.WriteLine("Plane flying");
        }
    }
}
