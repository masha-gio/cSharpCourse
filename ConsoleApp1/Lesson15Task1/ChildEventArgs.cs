using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15Task1
{
    internal class ChildEventArgs: EventArgs
    {
        public Child Child { get; }

        public ChildEventArgs(Child child)
        {
            Child = child;
        }
    }
}
