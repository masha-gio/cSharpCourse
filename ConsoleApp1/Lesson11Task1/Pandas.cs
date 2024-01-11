using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11Task1
{
    public enum Gender
    {
        Male,
        Female
    }

    public enum Colour
    {
        WhiteBlack,
        White,
        Black
    }
    internal class Panda : IComparable<Panda>
    {
        public Gender Gender { get; set; }
        public Colour Colour { get; set; }
        public int HP { get; set; }
        public int Attack { get; set; }
        public int Defence { get; set; }
        public string Name { get; set; }

        public Panda(Gender gender, Colour colour, int hp, int attack, int defence, string name)
        {
            Gender = gender;
            Colour = colour;
            HP = hp;
            Attack = attack;                
            Defence = defence;
            Name = name;
        }

        public static Panda operator +(Panda parent1, Panda parent2)
        {
            if (parent1.Gender != parent2.Gender)
            {
                Colour newColour = parent1.Gender == Gender.Female ? parent1.Colour : parent2.Colour;
                return new Panda(parent1.Gender, newColour, 100, 10, 5, "Baby panda");
            }

            throw new InvalidOperationException("Can not breed pandas of the same gender");
        }
         public static Panda operator -(Panda attacked, Panda attacker)
        {
            int damage = attacker.Attack - attacked.Defence;
            attacked.HP = Math.Max(attacker.HP - damage, 1);
            return attacked;
        }

        public int CompareTo(Panda other)
        {
            if (Colour != other.Colour)
            {
                return Colour.CompareTo(other.Colour);
            }
            else
            {
                return HP.CompareTo(other.HP);
            }
        }

        public override string ToString()
        {
            return $"{Name}: Gender: {Gender}, Colour: {Colour}, HP: {HP}, Attack: {Attack}, Defence: {Defence}";
        }

    }
}
