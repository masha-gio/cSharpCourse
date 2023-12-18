using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9Task1and2
{
    internal class Zoo
    {
        private List<Herbivore> herbovireEnclosure;
        private List<Predator> preditorEnclosure;

        public Zoo()
        {
            herbovireEnclosure = new List<Herbivore>();
            preditorEnclosure = new List<Predator>();
        }

        public void AcceptAnimal(Animal animal)
        {
            if (animal is Herbivore)
            {
                Console.WriteLine($"Accept {animal.Name} to Herbivore enclosure");
                herbovireEnclosure.Add((Herbivore)animal);
            }
            else if (animal is Predator)
            {
                Console.WriteLine($"Accept {animal.Name} to Predator enclosure");
                preditorEnclosure.Add((Predator)animal);
            }
            else
            {
                Console.WriteLine($"Unknown animal type: {animal.Name}");
            }
        }

        public void DisplayEnclosures()
        {
            Console.WriteLine("Predator enclosure:");
            foreach (Predator pred in preditorEnclosure)
            { 
                Console.WriteLine($" - {pred.Name}");            
            }
            Console.WriteLine("Herbivore enclosure:");
            foreach (Herbivore herbivore in herbovireEnclosure)
            {
                Console.WriteLine($" - {herbivore.Name}");
            }
        }
    }
}
