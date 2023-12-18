using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9Task1and2
{
    internal class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Animal(string name, int age) { 
            Name = name;
            Age = age;        
        }

        public virtual void Live()
        {
            Console.WriteLine($"{Name} lives his life");
        }




       }
}
