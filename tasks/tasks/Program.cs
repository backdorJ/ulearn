


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

            try
            {
                Console.WriteLine("Enter rCircle - ");
                double rCircle = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter side rectangular");
                double sideRectangular = double.Parse(Console.ReadLine());

                double sCircle = Math.PI * Math.Pow(rCircle, 2);
                double sRectangular = Math.Pow(sideRectangular, 2);

                if (sideRectangular > sCircle)
                {
                    Console.WriteLine("Площадь прямоугльника больше, чем площадь круга ! ");
                }
                else
                {
                    Console.WriteLine("Плоащь круга больше, чем площадь прямоугльника");
                }


            }
            catch 
            {

                Console.WriteLine("Неверный формат числа ");
            }

        }
    }
}