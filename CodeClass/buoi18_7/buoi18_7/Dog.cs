using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi18_7
{
    internal class Dog : Animal
    {
        public Dog()
        {
            Console.WriteLine("Dog constructor");
        }
        public new void Talk()
        {
            Console.WriteLine("Dog talk");
        }

    }
}
