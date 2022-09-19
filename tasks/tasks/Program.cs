


using System.Globalization;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace Task
{
    class Lesson
    {


        static void Main()
        {
            //Console.Write("Enter x - ");
            //double x = double.Parse(Console.ReadLine());
            //Console.Write("Enter y - ");
            //double y = double.Parse(Console.ReadLine());

            //if (x > y)
            //    Console.WriteLine("Число " + x + " больше чем " + y);
            //else
            //    Console.WriteLine("Число " + y + " больше чем " + x);


            //Console.Write("Enter x - ");
            //double x = double.Parse(Console.ReadLine());
            //Console.Write("Enter y - ");
            //double y = double.Parse(Console.ReadLine());

            //if (x > y)
            //{
            //    Console.WriteLine("x - max");
            //    Console.WriteLine("y - min");
            //}
            //else
            //{
            //    Console.WriteLine("y - max");
            //    Console.WriteLine("x - min");
            //}



            //Console.Write("Enter x - ");
            //double x = double.Parse(Console.ReadLine());
            //Console.Write("Enter y - ");
            //double y = double.Parse(Console.ReadLine());

            //double xInKm = x * 1000;
            //double yInF = y * 0.305;

            //if (xInKm > yInF)
            //{
            //    Console.WriteLine("Distance in km > Distance in fountss");
            //}
            //else Console.WriteLine("Distance in founts > Distanse in km");


            //double x = double.Parse(Console.ReadLine());
            //double y = double.Parse(Console.ReadLine());

            //double kmInH = (x * 3600) / 1000;
            //double mInS = y;

            //if (kmInH > mInS)
            //    Console.WriteLine("KmInH > mInS");
            //else
            //    Console.WriteLine("mInS > KmInH");

            //try
            //{
            //    Console.WriteLine("Enter rCircle - ");
            //    double rCircle = double.Parse(Console.ReadLine());
            //    Console.WriteLine("Enter side rectangular");
            //    double sideRectangular = double.Parse(Console.ReadLine());

            //    double sCircle = Math.PI * Math.Pow(rCircle, 2);
            //    double sRectangular = Math.Pow(sideRectangular, 2);

            //    if (sideRectangular > sCircle)
            //    {
            //        Console.WriteLine("Площадь прямоугльника больше, чем площадь круга ! ");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Плоащь круга больше, чем площадь прямоугльника");
            //    }


            //}
            //catch 
            //{

            //    Console.WriteLine("Неверный формат числа ");
            //}

            //try
            //{
            //    Console.WriteLine("Enter volume first - ");
            //    double firstVolume = double.Parse(Console.ReadLine());
            //    Console.WriteLine("Enter volume second - ");
            //    double secondVolume = double.Parse(Console.ReadLine());
            //    Console.WriteLine("Enter first weight - ");
            //    double firstWeight = double.Parse(Console.ReadLine());
            //    Console.WriteLine("Enter second weight - ");
            //    double secondWeight = double.Parse(Console.ReadLine());


            //    double pFirst, pSecond;

            //    pFirst = firstWeight / firstVolume;
            //    pSecond = secondWeight / secondVolume;

            //    if (pFirst > pSecond)
            //        Console.WriteLine("Плотность первого тела больше, чем второое");
            //    else
            //        Console.WriteLine("Плотность второго тела больше, чем первое");

            //}
            //catch 
            //{

            //    Console.WriteLine("Неверный формат числа");
            //}



            //try
            //{
            //    Console.WriteLine("Введите U1 - ");
            //    double u1 = double.Parse(Console.ReadLine());
            //    Console.WriteLine("Введите R1 - ");
            //    double r1 = double.Parse(Console.ReadLine());
            //    Console.WriteLine("Введите U2 - ");
            //    double u2 = double.Parse(Console.ReadLine());
            //    Console.WriteLine("Введите R2 - ");
            //    double r2 = double.Parse(Console.ReadLine());


            //    double i1 = u1 / r1;
            //    double i2 = u2 / r2;

            //    if (i1 > i2)
            //        Console.WriteLine("Наименьший ток протекает в i2");
            //    else
            //        Console.WriteLine("Наименьший ток протекает в i1");


            //}
            //catch 
            //{

            //    Console.WriteLine("Неверный формат числа ! ");
            //}


            //try
            //{
            //    Console.WriteLine("Enter value for a - ");
            //    double a = double.Parse(Console.ReadLine(), System.Globalization.NumberStyles.Any);
            //    Console.WriteLine("Enter value for b - ");
            //    double b = double.Parse(Console.ReadLine(), System.Globalization.NumberStyles.Any);
            //    Console.WriteLine("Enter value for c - ");
            //    double c = double.Parse(Console.ReadLine(), System.Globalization.NumberStyles.Any);
            //    double getDiscr,x1,x2;
            //    if (a > 0)
            //    {
            //        getDiscr = Math.Pow(b, 2) - 4 * a * c;
            //        x1 = -b + Math.Sqrt(getDiscr) / (2 * a);
            //        x2 = -b - Math.Sqrt(getDiscr) / (2 * a);
            //        if (x1 != 0 || x2 != 0)
            //        {
            //            Console.WriteLine($"Первый корень равен = {x1}");
            //            Console.WriteLine($"Второй корень рваен = {x2}");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Первый корень равен = 0");
            //            Console.WriteLine("Второй корень равен = 0");   
            //        }
            //    }

            //}
            //catch 
            //{

            //    Console.WriteLine("Неверный формат числа ! ");
            //}


            //try
            //{
            //    int nowYear = 2022;
            //    int nowNumber = 19;
            //    Console.WriteLine("Введите ваш год вашего рождения - ");
            //    int humanYear = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Введите число вашего рождения -  ");
            //    int humanNumber = int.Parse(Console.ReadLine());

            //    if (humanYear < nowYear && humanNumber >= nowNumber )
            //    {
            //        int result = nowYear - humanYear;
            //        Console.WriteLine($"Вам " + result + " год/лет");
            //    }
            //    if (humanYear < nowYear && humanNumber < nowNumber )
            //    {
            //        int result = nowYear - humanYear - 1;
            //        Console.WriteLine("Вам " + result + " год/лет");
            //    }
            //    else if (humanYear > nowYear)
            //    {
            //        Console.WriteLine("Чедлвек еще не родился");
            //    }

            //}
            //catch 
            //{

            //    Console.WriteLine("Неверный формат числа");
            //}





            //int numberA, numberB;
            //char chA, chB;
            //Console.WriteLine("Input A - ");
            //chA = char.Parse(Console.ReadLine());
            //numberA = int.Parse(Console.ReadLine());
            //Console.WriteLine("Input B - ");
            //chB = char.Parse(Console.ReadLine());
            //numberB = int.Parse(Console.ReadLine());

            //Console.WriteLine($"{chA} {numberA}");
            //Console.WriteLine(chB - chA);
            //Console.WriteLine($"{chB} {numberB}");


            // Ладья 

            //if ((chA == chB) || numberA == numberB)
            //    Console.WriteLine("True");



            // Слона


            //char x = char.Parse(Console.ReadLine()); // 99 
            //int num = int.Parse(Console.ReadLine());

            //char x2 = char.Parse(Console.ReadLine()); // 98
            //int num2 = int.Parse(Console.ReadLine());
            //if (Math.Abs(x2 - x) == 1 || Math.Abs(x2 - x) == 5 || Math.Abs(x2 - x) == 3 || Math.Abs(x2 - x) == 4 || Math.Abs(x2 - x) == 2 || Math.Abs(x2 - x) == 6 || Math.Abs(x2 - x) == 7)
            //{
            //    if (Math.Abs(x - x2) == Math.Abs(num - num2))
            //    {
            //        Console.WriteLine("True");
            //    }
            //    else
            //    {
            //        Console.WriteLine("False");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("False");
            //}


            // Ферзь 



            //int numberA, numberB;
            //char chA, chB;
            //Console.WriteLine("Input A - ");
            //chA = char.Parse(Console.ReadLine());
            //numberA = int.Parse(Console.ReadLine());
            //Console.WriteLine("Input B - ");
            //chB = char.Parse(Console.ReadLine());
            //numberB = int.Parse(Console.ReadLine());


            //if ((chA == chB) || (numberA == numberB))
            //{
            //    Console.WriteLine("True");
            //}
            //else if (Math.Abs(chB-chA) == 1 || Math.Abs(chB - chA) == 2 || Math.Abs(chB - chA) == 3 || Math.Abs(chB - chA) == 4 || Math.Abs(chB - chA) == 5 || Math.Abs(x2 - x) == 6 || Math.Abs(x2 - x) == 7)
            //{
            //    if (Math.Abs(numberB - numberA) == Math.Abs(chB - chA))
            //    {
            //        Console.WriteLine("True");
            //    }
            //    else
            //    {
            //        Console.WriteLine("False");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("False");
            //}

















            //if ((numberA == 2) && (chA == chB))
            //{
            //    if ((numberB - numberA == 1) || (numberB - numberA == 2))
            //    {
            //        Console.WriteLine("True");
            //    }
            //    else
            //    {
            //        Console.WriteLine("False");
            //    }
            //}
            //else if ((chA == chB) && (numberB - numberA) == 1)
            //{
            //    if ((numberB - numberA) == 1)
            //    {
            //        Console.WriteLine("True");
            //    }
            //    else
            //    {
            //        Console.WriteLine("False");
            //    }
            //}



















            //Console.WriteLine("Введите число - ");
            //int value = int.Parse(Console.ReadLine());
            //int count = 0;

            //while (value != 0)
            //{
            //    value /= 10;
            //    count++;
            //}
            //Console.WriteLine(count);




        }
    }
}