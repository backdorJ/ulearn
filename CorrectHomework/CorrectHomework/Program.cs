using System.Diagnostics.Metrics;

namespace Project
{
    class Lesson
    {


        static void Main()
        {
            Console.WriteLine("Введите n -");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите k - ");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите эпсилон - ");
            double e = double.Parse(Console.ReadLine());
            double sum = 0;
            double beforeCorrect = 0;
            double afterCorrect = 0;
            double factN = 1;
            double factK = 1;


            do
            {
                factN = factN * n;
                factK = factK * k;
                beforeCorrect = afterCorrect;
                afterCorrect = (Math.Pow(2, k) / (factN) / ((factK) * (factN - factK)));
                sum += afterCorrect;
                k--;
                n--;
            } while (Math.Abs(beforeCorrect - afterCorrect) > e);

            sum = -2 + 2 * sum;

            Console.WriteLine(sum);


        }
    }
}