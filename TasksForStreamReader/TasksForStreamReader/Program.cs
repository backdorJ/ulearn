namespace Project
{
    class Lesson
    {
        static void Main()
        {
            Console.WriteLine("Введите строку - ");
            string text = Console.ReadLine();
            string path = @"C:\Users\Damir\Desktop\text.txt";

            using (StreamWriter sw = new StreamWriter(path, false))
            {
                sw.WriteLine(text);
                sw.Close();
            }
            string[] subs;
            using(StreamReader sr = new StreamReader(path))
            {
                subs = sr.ReadLine().ToUpper().Split();
            }

            Console.WriteLine("Введите слово которое хотетите првоерть, является ли она подстрокой" +
                " текста !");
            string line = Console.ReadLine();

            bool flag = false;

            foreach (var item in subs)
            {
                if (line.ToUpper() == item)
                    flag = true;
            }

            if(flag)
                Console.WriteLine($"Слово {line} является подстрокой текста !");
            else
                Console.WriteLine($"Слово {line} не является подстрокой текста !");
        }
    }
}