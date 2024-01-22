using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16Task6
{
    internal class Buyers
    {
        public int Id {  get; set; }
        public string Name { get; set; }

        // использовать для правила "один покупательб одна машина"
        //public int CarId { get; set; }

        //один покупатель, несколько машин
        public List<int> CarId { get; set; }
    }
}
