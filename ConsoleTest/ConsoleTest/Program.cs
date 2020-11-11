using System;
using PortLibrary;

namespace ConsoleTest
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            MyClass Test_icles = new MyClass("Henning", 15);

            Console.WriteLine(Test_icles.Age + " " + Test_icles.Name);
        }
    }
}
