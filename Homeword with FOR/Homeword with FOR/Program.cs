
using System.Transactions;

namespace Hw
{
    class Lesson
    {
        static void Main()
        {

            // sin(x)+ sin(sin(x))+...+ sin(sin(sin(.....sin(x)))
            double n = double.Parse(Console.ReadLine());
            double sum1 = 0;
            double mulpiply = 1;
            int d;

            for (d = 1; d <= n; d++)
            {
                for (int j = 1; j <= d; j++)
                {
                    double radians = Math.PI * d / 180;
                    mulpiply *= Math.Sin(radians);
                }
                sum1 += mulpiply;
                mulpiply = 1;
            }

            Console.WriteLine(sum1);


            //cos x + cos x^2 + ... + cos x^k
            // С использованием Math.
            Console.WriteLine("Введите градус - ");
            double gradus = double.Parse(Console.ReadLine());
            double sumCos = 0;
            int k = int.Parse(Console.ReadLine());
            int i = 1;
            while (i <= k)
            {
                double rad = Math.PI * gradus / 180;
                sumCos += Math.Pow(Math.Cos(rad), i);
                i++;
            }
            Console.WriteLine(sumCos);


            ////cos f + cos f^2 + ... + cos f^l
            // Без использования Math.
            Console.WriteLine("Введите в градусах");
            double f = double.Parse(Console.ReadLine());
            double l = double.Parse(Console.ReadLine());
            double sumGr = 0;
            double res = 1;
            for (int g = 1; g <= l; g++)
            {
                res *= Math.Cos(f);
                sumGr += res;
            }
            Console.WriteLine($"Сумма {l} - косинусов = {sumGr}");
        }   
    }
}