using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12Task1
{
    internal abstract class Animal
    {
        protected string Name;
        protected int NumOfLegs;

        public void setName(string name) { this.Name = name; }
        public int getNumOfLegs() { return NumOfLegs; }
        public string getName() { return Name; }
        public void setNumOfLegs(int numOfLegs)
        {
            this.NumOfLegs = numOfLegs;
        }

        public Animal(string name, int numOfLegs)
        {
            this.Name = name;
            this.NumOfLegs = numOfLegs;
        }

        public abstract void displayAnimal();
    }
}
