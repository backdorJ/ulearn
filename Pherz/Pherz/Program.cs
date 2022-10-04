namespace Lesson
{
    class Lesson
    {
        public static bool IsCorrectMove(string from, string to)
        {
            var dx = Math.Abs(to[0] - from[0]); //смещение фигуры по горизонтали
            var dy = Math.Abs(to[1] - from[1]); //смещение фигуры по вертикали
            if (dx == dy || Math.Abs(dx-dy) == 4)
            {
                return true;
            }
            return false;
            
        }
        public static void Main()
            {
                TestMove("a1", "d4");
                TestMove("f4", "e7");
                TestMove("a1", "a4");
                 // Тестирование решения на секретных тестах
            }

            public static void TestMove(string from, string to)
            {
                Console.WriteLine("{0}-{1} {2}", from, to, IsCorrectMove(from, to));
            }
    }
}