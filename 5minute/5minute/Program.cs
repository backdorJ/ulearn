
using System.Diagnostics.CodeAnalysis;
namespace Project
{
    class Lesson
    {
        static void Main()
        {
            int[] arr = new int[] { 2, 10, 1, 1 };
            int count = 0;




            for (int i = 1; i < arr.Length; i++)
            {
                if ((i + 1 == arr.Length || arr[i] > arr[i + 1]) && (i == 0 || arr[i] > arr[i - 1]))
                    count++;
            }

            Console.WriteLine(count); // Ответ 2
        }
    }
}