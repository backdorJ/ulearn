using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generatePasswords
{
    internal class Person
    {
        public string name = "Marry";
        public int age = 19;
        
        public void Print()
        {
            Console.WriteLine($"Your name - {name}. Your age - {age}");
        }
    }
}
