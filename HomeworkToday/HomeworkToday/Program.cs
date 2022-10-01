namespace Project
{
    class Lesson
    {
        static void CorrectPi(double epsil)
        {
            int k;
            double sum = 0;
            double resultFormula = 0;
            double  befoResultFormula= 0;
            for (k = 1; Math.Abs(resultFormula - befoResultFormula) > epsil; ++k)
            {
                befoResultFormula = resultFormula;
                resultFormula = 1 / ((4 * k - 2) * (4 * k - 1));
                sum += resultFormula;
            }
            sum = 8 * sum + 2 * Math.Log(2);
            Console.WriteLine(sum);
        }
        static void Main()
        {
            CorrectPi(0.001);
        }
    }
}