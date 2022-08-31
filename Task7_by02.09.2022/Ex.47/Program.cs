//  Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] CreateArray2D(int n, int m, int min, int max)
{
    double[,] array = new double[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            array[i,j] = Math.Round(new Random().NextDouble()*(max+(min*(-1)))-(min*(-1)), 2);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    return array;
}

Console.Clear();
Console.Write("Введите через пробел значения m и n для генерации массива размером m x n: ");
string[] mn = Console.ReadLine().Split();
int m = Convert.ToInt32(mn[0]);
int n = Convert.ToInt32(mn[1]);
Console.WriteLine();
CreateArray2D(m, n, -10, 10);
Console.WriteLine();