

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
            Console.WriteLine($"���� ��� - {firstName}");
            Console.WriteLine($"���� ������� - {secondName}");
            Console.WriteLine($"���� �������� - {lastName}");
            Console.WriteLine($"��� ������� - {age}");
            Console.WriteLine($"���� ������ - {group}");
            Console.WriteLine($"��� id ����� - {id}");
        }
    }
}