using System;
using System.ComponentModel.DataAnnotations;

namespace Project
{
    class Lesson
    {
        static int[,] GenerationMatrix(int n)
        {
            Random r = new Random();
            int[,] matrix = new int[n,n];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = r.Next(1, 1000);
                }
            }
            return matrix;
        }

        static void WriteMatrix(int[,] matrix, string nameFile)
        {
            using(StreamWriter sw = new StreamWriter(nameFile, false))
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        sw.Write(matrix[i, j] + " ");
                    }
                    sw.WriteLine();
                }
            }
        }

        static int[,] ReadMatrix(string nameFile, int n)
        {
            int[,] array = new int[n,n];
            
            using(StreamReader sr = new StreamReader(nameFile))
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    var subs = sr.ReadLine().Trim().Split(' ');
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        array[i, j] = int.Parse(subs[j]);
                    }
                }
            }

            return array;
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i,j],3} ");
                }
                Console.WriteLine();
            }
        }
        static int[,] GenerateOddMatrix(int n)
        {
            int[,] matrix = new int[n, n];
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int temp = r.Next(1, 100);
                    if (temp % 2 != 0)
                        matrix[i, j] = temp;
                    else
                        matrix[i, j] = temp + 1;
                }
            }
            return matrix;
        }

        static int[,] SumMatrix(int[,] matrix1, int[,] matrix2, int n)
        {
            int[,] result = new int[n, n];
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    result[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
            return result;
        }

        static string MaxProstDigits(int[,] mat)
        {
            string line = "";
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    for (int k = 2; k <= (int)Math.Sqrt(mat[i,j]); k++)
                    {
                        if ((mat[i,j] % k == 0)) {
                            line += mat[i,j].ToString();
                        }
 
                        
                    }
                }
            }
            return line;
        }

        static bool MagixSquare(int[,] matrix1, int[,] matrix2)
        {
            bool flag = true;
            int k = 0;
            int sum = 0;
            int sum1 = 0;

            for (int j = 1; j < matrix2.GetLength(1); j++)
            {
                k += matrix2[1, j];
            }

            for (int i = 1; i < matrix2.GetLength(0); i++)
            {
                sum = 0;
                for (int j = 1; j < matrix2.GetLength(1); j++)
                {
                    sum += matrix2[i, j];
                }
                if (sum != k)
                    flag = false;
            }

            for (int j = 1; j < matrix2.GetLength(0); j++)
            {
                sum = 0;
                for (int i = 0; i < matrix2.GetLength(1); i++)
                {
                    sum += matrix2[i, j];
                }
                if (sum != k)
                    flag = false;
            }
            sum = 0;
            sum1 = 0;
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    if (i == j)
                        sum += matrix2[i, j];
                    if (i + j == matrix1.GetLength(0) + 1)
                        sum1 += matrix2[i, j];
                }
            }
            if (sum != k)
                flag = false;
            if (sum != k)
                flag = false;

            if (flag)
                return true;
            return false;
        }
        static void Main()
        {
            Console.WriteLine("Введите размер");
            int n = int.Parse(Console.ReadLine());
            string file = "text.txt";
            int[,] mat = GenerationMatrix(n);
            WriteMatrix(mat, file);


            // Сгенерировать матрицу из нечетных чисел вторую прочитать из файла

            int[,] matrix = GenerateOddMatrix(n);
            int[,] rMat = ReadMatrix(file, n);
            Console.WriteLine("Нечетная матрица !");
            PrintMatrix(matrix);
            Console.WriteLine("Матрица считанная с файла");
            PrintMatrix(rMat);
            //==================================================================

            /*
             * 
             *    Узнать является ли вторая матрица - магическим квадратом.  
             */

             if(MagixSquare(matrix,rMat))
                Console.WriteLine("rMat - Является магическим кубом !");
             else
                Console.WriteLine("rMat - не является магическим кубом !");


            /*
             * 
             * Сложить две матрицы. Вывести столбец матрицы в котором наибольшее количество 
                простых чисел.
             * 
             */

            int[,] resultMatrix = SumMatrix(matrix, rMat, n);
            string line = MaxProstDigits(resultMatrix);
            Console.WriteLine(line);

        }
    }
}