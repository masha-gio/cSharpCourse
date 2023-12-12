using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7Task2
{
    internal class Cone
    {
        public double Radius { get; set; }
        public double Height { get; set; }

        public Cone(double r, double h) {
            Radius = r;
            Height = h;
        }

        public double BaseSurfaceArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public double TotalSurfaceArea()
        {
            return Math.PI * Radius * (Radius + Height);
        }
    }
}
