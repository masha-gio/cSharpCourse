using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9Task1and2
{
    internal class Herbivore: Animal
    {
        public bool EatsGrass { get; set; }

        public Herbivore(string name, int age, bool eatsGrass): base(name, age)
        { 
        EatsGrass = eatsGrass;
        }
        public override void Live()
        {
            if(EatsGrass)
            {
                Console.WriteLine($"{Name} eats grass");
            }
            else
            {
                Console.WriteLine($"{Name} lives his life");
            }
        }
    }
}
