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
            int x = 2;
            int out = x;
            int i = 1;

            do
            {
                factN = factN * n;
                factK = factK * k;
                out = out * x;
                beforeCorrect = afterCorrect;
                afterCorrect = (out / (factN) / ((factK) * (factN - factK)));
                sum += afterCorrect;
            
                k--;
                n--;
                i++;
            } while ((Math.Abs(beforeCorrect - afterCorrect) > e) || (i < k));

            sum = -2 + 2 * sum;

            Console.WriteLine(sum);


        }
    }
}
