using System;
namespace PortLibrary
{
    public class MyClass
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public MyClass(string name, int age)
        {
            this.Age = age;
            this.Name = name;
        }
    }
}
