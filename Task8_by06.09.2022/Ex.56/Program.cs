// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

int[] SumLinesArray2D(int[,] array)
{
    int[] sumlines = new int[array.GetLength(0)];
    sumlines[0] = 0;
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumlines[i] += array[i, j];
        }
    }
    return sumlines;
}

void FindMinElement(int[] array)
{
    int min = array[0];
    int minline = 1;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
            minline += i;
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов -> {minline}");
    Console.WriteLine($"Сумма элементов {minline} строки = {min}");
}

Console.Clear();
Console.WriteLine("Генерируем массив целых чисел 4х6...");
Console.WriteLine();
int[,] array = GetArray2D(4, 6, 0, 9);
Console.WriteLine();
FindMinElement(SumLinesArray2D(array));
Console.WriteLine();
