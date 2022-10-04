namespace Project
{
    class Lesson
    {
        static void GetOtricValue()
        {
            int[] arr = new int[] {10,20,40,1000,-1012,10000,123124,100,12030123};

            int max = arr[0];
            int maxI = 0;
            int i;
            for (i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    maxI = i;
                    
                }
            }
            Console.WriteLine(maxI);
            
        }
        
        static void GetMaxOtric()
        {
            int[] arr = new int[] { 10, 20, -5, 40, 5,100,  -3 };

            int maxOtricValue = -1;
            int minPlus = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < 0  && maxOtricValue == -1)
                {
                    maxOtricValue = arr[i];
                }
                else if (arr[i] < 0 && arr[i] > maxOtricValue) { maxOtricValue = arr[i];}
                if (arr[i] < minPlus && arr[i] > 0)
                {
                    minPlus = arr[i];
                }
            }
            Console.WriteLine("Минимальный положительный = " + minPlus);
            Console.WriteLine("Максимальное отрицательное = " + maxOtricValue);


        }

        static void Value()
        {
            int[] arr = new int[] { 10, 20, -5, -6, -4, 100, -1, 0, 10000 };


            int maxOtric = -1;
            int minPolo = arr[0];


            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < 0 && maxOtric == -1)
                {
                    maxOtric = arr[i];
                }
                else if (arr[i] < 0 && arr[i] > maxOtric)
                {
                    maxOtric = arr[i];
                }

                if (arr[i] > 0 && arr[i] < minPolo) { minPolo = arr[i]; }
            }
            Console.WriteLine("Максимальное отрицательное число - " + maxOtric);
            Console.WriteLine("Минимальное положительное число - " + minPolo);
        }

        static void CountMinValue()
        {
            int[] mas = { -10,-30,-40,50,100,300,10,-1, };
            int cntmin = 0;
            int posled = 0, pp = 0;
            int k = 0;
            double min = double.MaxValue;
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] < min || mas[i] < 0)
                {
                    k += 1;
                    min = mas[i];
                    posled = k;
                    cntmin++;
                    pp = posled;
                }

            }
            Console.WriteLine("Кол-во минимальных - " + cntmin);
            Console.WriteLine("Index предпоследнего числа - " + (pp-2));
        }

        static void DefaultNumbers()
        {
            int[] arr = { 1, 2, 100, 923, 13, 1002, 5 };
            bool fl = false;

            for (int i = 0; i < arr.Length; i++)
            {
                if ((arr[i] % 2 == 0) && (arr[i] / 1 == arr[i])) { fl = true; break; }
            }
            if (fl)
            {
                Console.WriteLine("В массиве есть простые числа!");
            }
            else
            {
                Console.WriteLine("В массиве нет простых чисел");
            }
        }
        
        static void GetRepeatNumbers()
        {
            int[] arr = new int[6] { 101,200,400,200,300,400 };

            int r = arr[0];
            bool fl = false;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == r) { fl = true; break; }
                else if (arr[i] == arr[arr.Length - 1]) { fl = true; break; }
            }

            Console.WriteLine(fl);
        }
        static void NotRepeatValue()
        {
            int[] arr = new int[6] { 6,6,6,5,6,6 };

            int r = arr[0];
            bool fl = false;
            int i, k;
            k = 1;
            for (i = 1, k += 1; i < arr.Length + 1; i++)
            {
                if (arr[i] != arr[k]) { fl = true; break; }
                else if (arr[i] != arr[arr.Length - 1]) { fl = true; break; }
            }
            Console.WriteLine(fl);
        }

        static void Main()
        {

        }
    }
}