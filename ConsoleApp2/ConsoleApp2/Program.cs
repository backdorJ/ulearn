using System;


using ConsoleApp2;
using System.Globalization;

namespace Project
{
    class Lesson
    {

        public static bool IsAllDigit(string raw)
        {
            string s = raw.Trim();
            if (s.Length == 0)
            {
                return false;
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsDigit(s[i]) == false)
                {
                    return false;
                }
            }
            return true;
        }

        static void Main()
        {

            static int Compare(string s1, string s2)
            {
                if (s1.Length > s2.Length)
                    return 1;
                if (s1.Length < s2.Length)
                    return -1;

                return 0;
            }

            #region
            Console.WriteLine("Input x");
            //double x = double.Parse(Console.ReadLine(), System.Globalization.NumberStyles.None);
            //double y = 10;
            //double p = x;

            //int i = 9;

            //while (i > 0)
            //{
            //    y = y + i * p;
            //    p = p * x;
            //    i--;
            //}
            //Console.WriteLine(y);

            //double x = Math.PI / 2;
            //double y = Math.Cos(x);
            //double p = y;
            //int i = 10;
            //while (i > 0)
            //{
            //    y = y + p;
            //    p = p * x;
            //    i--;
            //}
            //Console.WriteLine(y);


            //double x = Math.PI / 4;
            //double y = Math.Sin(x);
            //double p = y;
            //int k = 20;
            //while (k > 0)
            //{
            //    y = y + p;
            //    p *= p;
            //    k--;
            //}
            //Console.WriteLine(y);
            #endregion

            //int year = int.Parse(Console.ReadLine());
            //if (year % 4 == 0 || (year % 100 == 0 && year % 400 ==0))
            //{
            //    Console.WriteLine("Год високосный");
            //}

            // Узнает високосный ли год !
            DateTime thisYear = new DateTime(1768, 1, 1);
            bool isLeapYear = DateTime.IsLeapYear(thisYear.Year);
            Console.WriteLine(isLeapYear);

            //


            //DateTime thisMoment = DateTime.Now;
            //DateTime anHourFromNow = thisMoment.AddHours(10);
            //int year = DateTime.Now.Year;
            //DayOfWeek dayOfWeek = DateTime.Now.DayOfWeek;
            //Console.WriteLine(year);
            //Console.WriteLine(dayOfWeek);
            //DateTime day = DateTime.Now.Date;
            //DateTime date = DateTime.Today;
            //TimeSpan time = thisMoment.TimeOfDay;
            //TimeSpan duraction = new TimeSpan(3, 0, 0, 0);
            //Console.WriteLine(duraction);
            //DateTime anHourAfterMidnight = DateTime.Today.Add(duraction);
            //Console.WriteLine("Час после полуночи - {0}", anHourAfterMidnight);
            //DateTime midnight = anHourAfterMidnight.Subtract(duraction);
            //Console.WriteLine("За час до 01:00 - {0}", midnight);



            //int intValue = 10;
            //long longValue;
            //longValue = intValue;
            //Console.WriteLine(longValue);


            //int intValue;
            //long longValue = 102;
            //intValue = (int)longValue;
            //Console.WriteLine(intValue);

            //Student s1 = new Student();

            //s1.name = "Jenn";
            //Student s2 = new Student();
            //s2.name = s1.name.ToUpper();
            //Console.WriteLine("s1 - " + s1.name + ", s2 - " + s2.name);

            //string sentence = "";
            //for (;;)
            //{

            //    Console.WriteLine("Введите строку - ");
            //    string line = Console.ReadLine();

            //    string[] terms = new string[] { "exit", "EXIT", "Quit", "QUIT" };
            //    bool quirring = false;

            //    //foreach  (string term in terms)
            //    //{
            //    //    if (string.Compare(line, term) == 0)
            //    //    {
            //    //        quirring = true;
            //    //    }
            //    //}
            //    //if (string.Compare("exit",line,true)  == 0 || string.Compare("quit", line, true) == 0)
            //    //{
            //    //    quirring = true;
            //    //}

            //    switch (line)
            //    {
            //        case "exit":
            //        case "EXIT":
            //        case "quit":
            //        case "QUIT":
            //            quirring = true;
            //            break;
            //    }
            //    if (quirring == true)
            //    {
            //        break;
            //    }

            //    sentence = string.Concat(sentence, line);
            //    Console.WriteLine("\nВы ввели:\n" + sentence);
            //    Console.WriteLine("\nПолучилось\n: " + sentence);

            bool choose = IsAllDigit("2123123");
            Console.WriteLine(choose);

        }


        //string chack = "hello";
        //string toUpper = char.ToUpper(chack[0]).ToString() + chack.Substring(1, chack.Length - 1);
        //Console.WriteLine(toUpper);

        //if (string.Compare(chack.ToUpper(CultureInfo.InvariantCulture),chack,false) == 0)
        //{
        //    Console.WriteLine("0");
        //}

        //bool isUpperCase = true;

        //string name = "hello";

        //foreach (char item in name)
        //{
        //    if (!char.IsUpper(item))
        //    {
        //        isUpperCase = false;
        //        Console.WriteLine("ad");
        //        break;
        //    }
        //}

        //string name = "edasdasdasdasd2asdafsxc3vxcv";
        //Console.WriteLine(name.Length);
        //char[] charsToLookFor = { '1', '2', '3' };
        ////int index = name.IndexOf('e');
        ////Console.WriteLine(index);
        //int index = name.IndexOfAny(charsToLookFor);
        //int index2 = name.LastIndexOfAny(charsToLookFor);
        //string sub = name.Substring(6, name.Length - 6);
        //Console.WriteLine(sub);


        //string str = "ad asd    ";
        //str = str.Trim();
        //Console.WriteLine(str);


        
        
        
    }
}