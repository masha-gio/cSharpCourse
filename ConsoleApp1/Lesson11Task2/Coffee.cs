using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11Task2
{
    public enum CoffeeStrength
    {
        Light,
        Medium,
        Strong
    }
    internal class Coffee
    {
        public int Volume { get; set; }
        public CoffeeStrength Strength { get; set; }

        public Coffee(int volume, CoffeeStrength strength)
        {
            Volume = volume;
            Strength = strength;
        }

        public override string ToString()
        {
            return $"Coffee: Volume - {Volume} ml, Strength - {Strength}";
        }
    }
}
