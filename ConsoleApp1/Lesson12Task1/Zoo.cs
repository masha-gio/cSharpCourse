using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lesson12Task1
{
    internal class Zoo
    {
            private List<ICarnivore> carnivoreEnclosure;
        private List<IHerbivore> herbivoreEnclosure;

        public Zoo()
        {
            carnivoreEnclosure = new List<ICarnivore>();
            herbivoreEnclosure = new List<IHerbivore>();
        }

        public void AddToCarnivoreEnclosure(ICarnivore carnivore)
        {
            carnivoreEnclosure.Add(carnivore);
        }

        public void AddToHerbivoreEnclosure(IHerbivore herbivore)
        {
            herbivoreEnclosure.Add(herbivore);
        }

        public void DisplayEnclosures()
        {
            Console.WriteLine("Carnivore Enclosure:");
            foreach (var carnivore in carnivoreEnclosure)
            {
                Console.Write(carnivore);
            }

            Console.WriteLine("\nHerbivore Enclosure:");
            foreach (var herbivore in herbivoreEnclosure)
            {
                Console.WriteLine(herbivore);
            }
        }
    }
}
