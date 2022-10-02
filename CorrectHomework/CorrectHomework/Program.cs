namespace Project
{
    class Lesson
    {
        static double fact(double n) // Вычисляю факториал числа   
        {
            double r;
            for (r = 1; n > 0; n--)
            {
                r *= n;
            }
            return r;
        }

        static double CRefer(double n, double k)
        {
            return fact(n) / (fact(k) * fact(n-k));
        }

        static void CorrectPi(double e, double enterK, double nEnter)
        {
            double sum = 0;
            double k = enterK;
            double n = nEnter;
            double beforeCorrect = 0;
            double afterCorrect = 0;
            do
            {
                beforeCorrect = afterCorrect;
                afterCorrect = (Math.Pow(2, k) / CRefer(n, k));
                sum += afterCorrect;
                k--;
                n--;
            } while (Math.Abs(beforeCorrect - afterCorrect) > e);
            sum = -2 + 2 * sum;
            Console.WriteLine(sum);
        }

        static void Main()
        {
            CorrectPi(0.01, 5, 6);
        }
    }
}