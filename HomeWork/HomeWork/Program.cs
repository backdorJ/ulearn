
namespace Honework
{
    class Lesson
    {
        static void Main()
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if ((y <= 1 && y >= 0 && Math.Abs(x) <= 1) && (Math.Abs(x) + Math.Abs(y) <= 1))
            {
                Console.WriteLine("True");
            }
            else if (Math.Abs(x) <= 1 && ((y >= -1 * x * x) && (y < 0)))
            {
                Console.WriteLine("True");

            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}