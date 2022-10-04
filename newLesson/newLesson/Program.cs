


using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace Project
{
    class Lesson
    {
        static double sin(double a)
        {
            return Math.Sin(a);
        }
        static void Main()
        {
            //double a = double.Parse(Console.ReadLine());
            //double e = 0.01;
            //int i = 1;
            //for (i = 1; a > e; i++)
            //{
            //    a = sin(a);
            //}

            //Console.WriteLine($"Сумма - {a}");
            //Console.WriteLine($"Кол-во - {i}");


            //int x = 100;
            //int digit;
            //int digit2;
            //int digit3;

            //while (x < 999 && x > 99)
            //{
            //    digit = x % 10;
            //    digit2 = x % 100;
            //    digit3 = x / 100;
            //    if (digit != digit2 && digit2 != digit3 && digit != digit3)
            //    {
            //        Console.WriteLine(x);
            //    }
            //    x++;
            //}


            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if ((y <= 1 && y >= 0 && Math.Abs(x) <= 1) && (Math.Abs(x) + Math.Abs(y) <= 1))
            {
                Console.WriteLine("принадлежит");
            }
            else if (Math.Abs(x) <= 1 && ((y >= -1 * x * x) && (y < 0)))
            {
                Console.WriteLine("принадлежит");

            }
            else
            {
                Console.WriteLine("не принадлежит");
            }






            }
    }
}