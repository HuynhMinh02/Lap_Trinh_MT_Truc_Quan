using System;
using System.IO;

namespace buoi187
{
    internal class Animal
    {
        public class Animal
        {
            public Animal()
            {

                public string color = "White";

        }
    }
    public class Dog : Animal
    {
        string color = "Black";
        public void showColor()
        {
            Console.Writeln(base.color);
            Console.Writeln(color);
        }
    }
    public class TestBase
    {
        public static void Main()
        {
            Dog d = new Dog();
            d.showColor();
        }
    }
}
}

