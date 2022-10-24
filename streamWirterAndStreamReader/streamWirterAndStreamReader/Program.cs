string path = @"C:\Users\Damir\Desktop\pad.txt";
string text = "3 5\n1 2 3 4 5\n5 6 7 8 9\n1 5 6 7 8";
using (StreamWriter st = new StreamWriter(path, false))
{
    st.WriteLine(text);
    st.Dispose();
}

int[,] matrix;
using (StreamReader sr = new StreamReader(path))
{
    int[] subs = Array.ConvertAll(sr.ReadLine().Split(), Convert.ToInt32);

    int m = subs[0];
    int n = subs[1];

    matrix = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        var row = sr.ReadLine().Split();
        for (int j = 0; j < n; j++)
            matrix[i,j] = Convert.ToInt32(row[j]);
    }
}

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i,j],3}");
    }
    Console.WriteLine();
}