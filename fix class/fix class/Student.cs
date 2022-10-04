using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fix_class
{
    class Student
    {
        public Guid id;
        public string firstName;
        public string mibbleName;
        public string lastName;
        public int age;
        public string group;

        public void Print()
        {
            Console.WriteLine($"Ваше имя - {firstName}");
            Console.WriteLine($"Ваша фамилия - {mibbleName}");
            Console.WriteLine($"Ваше отчество - {lastName}");
            Console.WriteLine($"Ваш возраст - {age}");
            Console.WriteLine($"Ваша группа - {group}");
            Console.WriteLine($"Ваш id номер - {id}");
        }

        public string GetFullName()
        {
            return $"{firstName} {mibbleName} {lastName}";
        }
    }
}
