using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12Task5
{
    internal class MobilePhone<T> where T : MobileNetwork
    {
        public T Network { get; set; }

        public MobilePhone(T network) { 
        Network = network;
        }

        public void DisplayNetworkInfo()
        {
            Console.WriteLine($"Mobile phone network is {Network}");
        }
    }
}
