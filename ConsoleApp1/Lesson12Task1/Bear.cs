using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12Task1
{
    internal class Bear : Animal, ICarnivore, IHerbivore
    {

        private string Sound;
        private string Colour;
        private string TypeC;
        private string FoodC;
        private string TypeH;
        private string FoodH;
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
        public string typeH
        {
            get { return typeC; }
            set => typeC = value;

        }
        public string foodH
        {
            get { return foodH; }
            set => foodH = value;
        }

        public Bear(string name, int numOfLegs, string sound, string colour, string foodC, string typeC, string foodH, string typeH) : base(name, numOfLegs)
        {
            this.Sound = sound;
            this.Colour = colour;
            this.FoodC = foodC;
            this.TypeC = typeC;
            this.FoodH = foodH;
            this.TypeH = typeH;
        }

        public void displayEatC()
        {
            Console.WriteLine($"Bear is a {TypeC} animal. Bear eats {FoodC}.");
        }

        public override void displayAnimal()
        {
            displayEatC();
            displayEatH();
            Console.WriteLine($"{Name} bear makes {Sound} sound. It's colour is {Colour}.");
        }

        public void displayEatH()
        {
            Console.WriteLine($"Bear is a {TypeH} animal. Bear eats {FoodH}.");
        }
    }
}
