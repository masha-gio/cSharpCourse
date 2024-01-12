using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lesson12Task1
{
    internal class Elephant: Animal, IHerbivore, IEquatable<Elephant>
    {
        private string Sound;
        private string Colour;
        private string TypeH;
        private string FoodH;
        private int Size;
        public string typeH
        {
            get { return typeH; }
            set => typeH = value;

        }
        public string foodH
        {
            get { return foodH; }
            set => foodH = value;
        }

        public Elephant(string name, int numOfLegs, string sound, string colour, int size, string foodH, string typeH) : base(name, numOfLegs)
        {
            this.Sound = sound;
            this.Colour = colour;
            this.NumOfLegs = numOfLegs;
            this.Size = size;
            this.FoodH = foodH;
            this.TypeH = typeH;
        }

        public void displayEatH()
        {
            Console.WriteLine($"Elephant is a {TypeH} animal. Cat eats {FoodH}.");
        }

        public override void displayAnimal()
        {
            displayEatH();
            Console.WriteLine($"{Name} elephant makes {Sound} sound. It's colour is {Colour}.");
        }

        bool IEquatable<Elephant>.Equals(Elephant? other)
        {
            return Name.Equals(other.Name) && Size == other.Size;
        }
    }

    
}
