using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12Task1
{
    internal class Cat: Animal, ICarnivore
    {
        private string Sound;
        private string Colour;
        private string TypeC;
        private string FoodC;
        public string typeC
        {
            get { return typeC; }
            set => typeC = value;

        }
        public string foodC
        {
            get { return foodC; }
            set => foodC = value;
        }

        public Cat(string name, int numOfLegs, string sound, string colour, string foodC, string typeC): base(name, numOfLegs) { 
        this.Sound = sound;
            this.Colour = colour;
            this.FoodC = foodC;
            this.TypeC = typeC;
                }

        public void displayEatC()
        {
            Console.WriteLine($"Cat is a {TypeC} animal. Cat eats {FoodC}.");
        }

        public override void displayAnimal()
        {
            displayEatC();
            Console.WriteLine($"Cat makes {Sound} sound. Cat colour is {Colour}.");
        }
    }
}
