using fix_class;

namespace Task
{
    class Lesson
    {
        static Student GetStudentInfo()
        {
            Student student = new Student();

            student.firstName = "Damir";
            student.mibbleName = "Nabiullin";
            student.lastName = "Rafaelevich";
            student.group = "11-208";
            student.id = Guid.NewGuid();
            student.age = 18;

            return student;
        }
        static void Main()
        {
            var student = GetStudentInfo();

            string fullName = student.GetFullName();
            Console.WriteLine(fullName);
               
        }
    }
}