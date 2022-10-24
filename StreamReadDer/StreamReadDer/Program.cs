using System.Text.RegularExpressions;

namespace Project
{
    class Lesson
    {
        static void Main()
        {
            string line = Console.ReadLine().ToLower();
            string path = @"C:\Users\Damir\Desktop\ulearn\TasksForStreamReader\file.txt";

            using(StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(line);
            }

            string resultText;

            using(StreamReader sr = new StreamReader(path))
            {
                resultText = sr.ReadLine();
            }

            Console.WriteLine("Введите текст который хотите проверить на подстроку !");
            string regexString = Console.ReadLine().ToLower();
            Regex regex = new Regex(regexString);

            if(regex.IsMatch(resultText))
                Console.WriteLine("Ваша строка является подстрокой, основного текста !");
            else
                Console.WriteLine("Ваша строка не является подстрокой, основного текста !");
        }
    }
}