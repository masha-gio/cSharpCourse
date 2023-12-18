using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lesson9Task1and2
{
    internal class Predator: Animal
    {
        public bool Bites { get; set; }

        public Predator(string name, int age, bool bites) : base(name, age)
        {
            Bites = bites;
        }
        public override void Live()
        {
            if (Bites)
            {
                Hunt();
            }
            else
            {
                Console.WriteLine($"{Name} lives his life");
            }
        }
        private void Hunt()
        {
            Console.WriteLine($"{Name} hunts");
        }
    }
}
