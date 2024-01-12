using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12Task4
{
    internal class Person: IComparable<Person>
    {
        public int Age;
        public string Gender;
        public string Name;

        public Person(string name, int age, string gender)
        {
            Age = age;
            Gender = gender;
            Name = name;
        }

        public int CompareTo(Person other)
        {
            int genderComparison = String.Compare(Gender, other.Gender, StringComparison.Ordinal);
            if (genderComparison != 0){
                return genderComparison;
            }
            return Age.CompareTo(other.Age);
        }
        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}, Gender: {Gender}";
        }
    }    
}
