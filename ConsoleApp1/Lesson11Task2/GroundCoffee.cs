using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11Task2
{
    internal class GroundCoffee
    {
        public int Volume { get; set; }
        public CoffeeStrength Strength { get; set; }

        public GroundCoffee(int volume, CoffeeStrength strength)
        {
            Volume = volume;
            Strength = strength;
        }

        public static Coffee operator +(Water water, GroundCoffee groundCoffee)
        {
            CoffeeStrength coffeeStrength = CalculateCoffeeStrength(water, groundCoffee);

            int coffeeVolume = Math.Min(water.Volume, groundCoffee.Volume);

            return new Coffee(coffeeVolume, coffeeStrength);
        }

        private static CoffeeStrength CalculateCoffeeStrength(Water water, GroundCoffee groundCoffee)
        {

            if (water.Temperature > 90 && groundCoffee.Strength == CoffeeStrength.Strong)
            {
                return CoffeeStrength.Strong;
            }
            else if (water.Temperature > 80 && groundCoffee.Strength == CoffeeStrength.Medium)
            {
                return CoffeeStrength.Medium;
            }
            else
            {
                return CoffeeStrength.Light;
            }
        }
    }
}
