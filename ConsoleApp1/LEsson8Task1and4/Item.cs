using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8Task1and4
{
    internal class Item
    {
        private string Name { get; set; }

        public Item()
        {
            Name = "unknown";
        }

        public void SetName(string newName)
        {
            Name = newName;
        }

        public string GetName()
        {
            return Name;
        }
    }
}
