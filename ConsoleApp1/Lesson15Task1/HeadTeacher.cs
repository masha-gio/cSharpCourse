using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15Task1
{
    internal class HeadTeacher { 

        public void ChildAddedToSchoolHandler(object sender, ChildEventArgs e)
        {
            Console.WriteLine($"Director: Notification received - Child {e.Child.Name} added to school");
        }
        public void NotifyParents(string childName)
        {
            Console.WriteLine($"Director: Notification sent to parents of {childName}. Welcome to school!");
        }
    }
}
