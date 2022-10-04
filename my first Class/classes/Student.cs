

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

        public void Print()
        {
            Console.WriteLine($"Ваше имя - {firstName}");
            Console.WriteLine($"Ваша фамилия - {secondName}");
            Console.WriteLine($"Ваше отчество - {lastName}");
            Console.WriteLine($"Ваш возраст - {age}");
            Console.WriteLine($"Ваша группа - {group}");
            Console.WriteLine($"Ваш id номер - {id}");
        }
    }
}