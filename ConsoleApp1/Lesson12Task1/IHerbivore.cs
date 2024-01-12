using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12Task1
{
    internal interface IHerbivore
    {
        string typeH { get; set; }
        string foodH { get; set; }

        void displayEatH();
    }
}
