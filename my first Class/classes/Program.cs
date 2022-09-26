using System;
using System.Text.RegularExpressions;

namespace Classes
{
    class Student
    {
        public int age;
        public Guid id;
        public string firstName;
        public string secondName;
        public string lastName;
        public string group;
    }

    class Lesson
    {

        static Student GetStudent(int age,string firstName,string secondName,string lastName, string group)
        {
            Student student = new();

            student.age = age;
            student.id = Guid.NewGuid();
            student.firstName = firstName;
            student.secondName = secondName;
            student.lastName = lastName;
            student.group = group;

            return student;
        }

        static void Print(Student student)
        {
            Console.WriteLine($"Ваше имя - {student.firstName}");
            Console.WriteLine($"Ваша фамилия - {student.secondName}");
            Console.WriteLine($"Ваше отчество - {student.lastName}");
            Console.WriteLine($"Ваш возраст - {student.age}");
            Console.WriteLine($"Ваша группа - {student.group}");
            Console.WriteLine($"Ваш id номер - {student.id}");
        }

        static void Main()
        {
            Console.WriteLine("Введиет ваш возраст - ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите ваше имя - ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Введите вашу фамилию - ");
            string secondName = Console.ReadLine();
            Console.WriteLine("Введите ваше отчество - ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Введите вашу группу - ");
            string group = Console.ReadLine();
            var student = GetStudent(firstName: firstName, secondName: secondName, lastName: lastName, age: age, group: group);

            Print(student);
        }
    }
}