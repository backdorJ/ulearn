


using generatePasswords;

namespace Project
{
    public class Lesson
    {
        static void Main()
        {
            Person tom = new Person();
            string namePerson = tom.name;
            int agePerson = tom.age;
            Console.WriteLine($"{namePerson} - {agePerson}");
            tom.Print();
        }
    }
}