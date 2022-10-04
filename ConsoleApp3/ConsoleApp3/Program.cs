

using ConsoleApp3;

namespace Lesson
{
    class Las
    {
        static bool IsAllDigit(string str)
        {
            string itIsNum = str.Trim();
            if (itIsNum.Length == 0)
            {
                return false;
            }
            for (int i = 0; i < itIsNum.Length; i++)
            {
                if (char.IsDigit(itIsNum[i]) == false)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main()
        {
            //string s = Console.ReadLine();
            //if (!IsAllDigit(s))
            //{
            //    Console.WriteLine("it`s not digit");
            //}

            //int number = int.Parse(s);
            //Console.WriteLine("2 * {0} = {1}", number , 2*number);

            //Console.WriteLine("Enter the numbers - ");
            //string input = Console.ReadLine();

            //char[] division = { ',', ' ' };
            //string[] segments = input.Split(division);

            //int sum = 0;

            //foreach (string s in segments)
            //{
            //    if (s.Length > 0)
            //    {
            //        if (IsAllDigit(s))
            //        {
            //            int num = 0;
            //            if (int.TryParse(s, out num))
            //            {
            //                Console.WriteLine("Очередное число = {0}", num);
            //                sum += num;
            //            }
            //        }
            //    }
            //}
            //Console.WriteLine("Сумма = {0}", sum);
            //string[] btothers = { "Hello", "Steave", "!" };
            //string bro = string.Join(" ", btothers);
            //Console.WriteLine(bro);

            //List<string> list = new List<string>() {"Mart ", " Kelly", " John", " Howerew " };

            //Console.WriteLine("Имена до обработки с разной длиной");

            //foreach (string item in list)
            //{
            //    Console.WriteLine("Имя " + item + " до обработки");
            //}


            //List<string> list2 = new List<string>();

            //foreach (string item in list)
            //{
            //    string name = item.Trim();
            //    list2.Add(name);
            //}
            //int maxLengh = 0;
            //foreach (string item in list2)
            //{
            //    if (item.Length > maxLengh)
            //    {
            //        maxLengh = item.Length;
            //    }
            //}

            //for (int i = 0; i < list2.Count; i++)
            //{
            //    list2[i] = list2[i].PadRight(maxLengh);
            //}

            //Console.WriteLine("Имена после обработки");

            //foreach (var item in list2)
            //{
            //    Console.WriteLine("Имя " + item + " после обработки");
            //}


            //Person person = new Person();

            //person.age = 12;
            //person.name = "Tom";

            //person.PrintInfo();
            //Console.WriteLine(Person.surname);

            //Person person = new Person();
            //Person person2 = new("Tom", 12, "Mart");
            //Person person3 = new("Tom");
            //string name = "0";
            //person.PrintInfo();
            //person2.PrintInfo();
            //person3.PrintInfo();
            //Console.WriteLine($"");




            //double x2 = Math.PI / 3;

            //double result = Math.Pow(Math.Cos(x2), 1);
            //double result2 = Math.Pow(Math.Cos(x2), 2);
            //double result3 = Math.Pow(Math.Cos(x2), 3);
            //Console.WriteLine(result+result2+result3);
            //double x = double.Parse(Console.ReadLine());
            //double sum = 0;
            //double i = 1;
            //double k = int.Parse(Console.ReadLine());
            //while (i <= k)
            //{
            //    sum = sum + Math.Pow(Math.Cos(x), i);
            //    i++;
            //}
            //Console.WriteLine(sum);

            //double sum = 1;
            //double res = 0;
            //double cos = Math.Cos(x);
            //int i = 1;
            //int k = int.Parse(Console.ReadLine());
            //while (i <= k)
            //{
            //    sum *= cos;
            //    res += sum;
            //    i++;
            //}
            //Console.WriteLine(res);

            //Помогите создать цикл расчета суммы произведений косинусов
            //P = cos(1) + cos(1)*cos(2) + cos(1)*cos(2)*cos(3) + ... + cos(1)*cos(2)*...*cos(n)
            //У меня не получается:



            //int i = 0;
            //double p = 1;
            //double sum = 1;
            //double x = int.Parse(Console.ReadLine());

            //while (i <= x)
            //{

            //    p *= Math.Cos(i);
            //    sum += p;
            //    i++;
            //}
            //double sum = 0;
            //double multiple = 1;
            //int n = 3;

            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //        multiple *= Math.Cos(i);
            //    sum += multiple;
            //    multiple = 1;
            //}


            //double n = double.Parse(Console.ReadLine());
            //double sum1 = 0;
            //double mulpiply = 1;

            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        double radians = Math.PI * i / 180;
            //        mulpiply *= Math.Sin(radians);
            //    }
            //    sum1 += mulpiply;
            //    mulpiply = 1;
            //}

            //Console.WriteLine(sum1);


            //decimal vklad = decimal.Parse(Console.ReadLine());
            //int month = int.Parse(Console.ReadLine());
            //int i = 1;

            //while (i <= month)
            //{

            //    vklad += vklad * 0.07M;
            //    i++;
            //}

            //Console.WriteLine(vklad);



            //for (int i = 1; i < 10; i++)
            //{
            //    for (int j = 1; j < 10; j++)
            //        Console.Write($"{i} * {j} = {i*j} \t");

            //    Console.WriteLine();
            //}

            //Console.WriteLine("Введите число в диапозоне от 0 до 10");
            //int result = 0;
            //while (true)
            //{
            //    Console.WriteLine("Введите первое число - ");
            //    int x = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Введите второе число - ");
            //    int y = int.Parse(Console.ReadLine());

            //    if ((x < 0 || x > 10) && (y > 10 || y < 0))
            //    {
            //        Console.WriteLine("Числа должны быть в диапазоне от 0 до 10");
            //    }

            //    if ((x <= 10 || x >= 0) && (y >= 0 && y <= 10))
            //    {
            //        result = x * y;
            //        break;
            //    }

            //}
            //Console.WriteLine(result);
            

        }
    }
}