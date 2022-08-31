// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] GetArray2D(int n, int m, int min, int max)
{
    int[,] array = new int[n, m];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    return array;
}

Console.Clear();
Console.Write("Введите через пробел кол-во строк и столбцов для генерации массива: ");
string[] inputData = Console.ReadLine().Split();
int rows = Convert.ToInt32(inputData[0]);
int columns = Convert.ToInt32(inputData[1]);
int[,] array = GetArray2D(rows, columns, 0, 10);
Console.WriteLine();

 for (int i = 0; i < columns; i++)
    {
        double summ = 0;
        double average = 0;
        for (int j = 0; j < rows; j++)
        {
            summ += array[j, i];
        }
        average = summ/rows;
        int count = i + 1;
        Console.WriteLine($"Среднее арифметическое {count} столбца = {average} ");
    }
Console.WriteLine();
