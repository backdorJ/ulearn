namespace Project
{
    class Lesson
    {
        static void Main()
        {
            List<string> line = new List<string>();
            Dictionary<string, int> map = new Dictionary<string, int>();

            using(StreamReader sr = new StreamReader("text.txt"))
            {
                string[] subs = sr.ReadToEnd().Trim().Split();
                foreach (var item in subs)
                {
                    line.Add(item);
                }
                foreach (var item in line)
                {
                    if (!map.ContainsKey(item))
                        map.Add(item, 1);
                    else
                        map[item]++;
                }
            }
            foreach (var item in map)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}