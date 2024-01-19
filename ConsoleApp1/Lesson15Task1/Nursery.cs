using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15Task1
{
    internal class Nursery
    {
        public event EventHandler<ChildEventArgs> ChildGraduated;

        public void GraduateChild(Child child)
        {
            Console.WriteLine($"Child {child.Name} graduated");

            if(child.Age > 6 )
            {
                OnChildGraduated(new ChildEventArgs(child));
            }
            else
            {
                Console.WriteLine($"Child {child.Name} is too young for school");
            }
        }

        protected virtual void OnChildGraduated(ChildEventArgs e)
        {
            ChildGraduated?.Invoke(this, e);
        }
    }
}
