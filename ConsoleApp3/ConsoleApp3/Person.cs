using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Person
    {
        public string name = "Undifited";
        public string street = "Undifited";
        public int age = 0;


        public Person(string name, int age, string street)
        {
            this.name = name;
            this.age = age;
            this.street = street;
        }
        public Person(string name)
        {
            this.name = name;
            age = 10;
        }
        public Person()
        {
            name = "Infifited";
            age = 10;
            street = "Infifited";
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Name : {name} - age {age}, street - {street}");
        }
    }
}
