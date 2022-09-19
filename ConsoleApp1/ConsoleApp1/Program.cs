

using System.Security.Cryptography;

namespace Project
{
    class Lesson
    {
        static void Main()
        {
            //int result = 0;
            //for (int i = 1; i < 1000; i++)
            //{
            //    if (i % 3 == 0 || i % 5 == 0)
            //    {
            //        result += i;
            //    }
            //}
            //Console.WriteLine(result);

            // За 1 ЧАС = 30 ГРАДУСОВ 
            // ЗА 1 минуту = 0.5 градуса
            //double h = 5;
            //double m = 5;

            //double of = Math.Abs(h*30 - m*6);
            //double result = of > 180 ? 360 - of : of;
            ////Console.WriteLine(result);
            //Console.WriteLine(5*30 - 12*6);


            //double h = 3;
            //double m = 45;

            //// расчёты
            //m %= 60;

            //double hOffset = h % 12;
            //hOffset += (1.0 / 60) * m;


            //double hAng = (360 / 12) * hOffset;
            //double mAng = (360 / 60) * m;

            //// результат
            //double result = Math.Abs(hAng - mAng);
            //result = result > 180 ? 360 - result : result;


            //// вывод результата
            //Console.WriteLine($"Время {h.ToString("00")}:{m.ToString("00")}");
            //Console.WriteLine($"Угол между стрелками: {result.ToString("F1")} °C");




            //double h = 10;
            //double m = 15;

            //double reHour = h * 30 + m * 0.5;
            //double reMin = m * 6;

            //double result = Math.Abs(reHour - reMin);
            //result = result > 180 ? 360 - result : result;
            //Console.WriteLine(result);


            double x = 1.0 / 10;
            double sum = 0;
            for (int i = 0; i < 10; i++)
                sum += x;
            Console.WriteLine(Math.Abs(sum - 1) < 1e-9);



        }
    }
}
