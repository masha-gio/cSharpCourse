using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12Task1
{
    internal interface ICarnivore
    {
        string typeC { get; set; }
        string foodC { get; set; }

        void displayEatC();
    }
}
