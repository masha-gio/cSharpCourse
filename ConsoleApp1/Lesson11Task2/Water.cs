﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11Task2
{
    internal class Water
    {
        public int Volume { get; set; }
        public int Temperature { get; set; }

        public Water(int volume, int temperature)
        {
            Volume = volume;
            Temperature = temperature;
        }
    }
}
