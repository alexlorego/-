// Задайте двумерный массив со случайными числами от -10 до 10. 
// Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

int[,] FillArray2D(int[,] array, int min, int max)
{
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

int SumMain(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j) sum += array[i, j];
        }
    }
    return sum;
}

Console.Clear();
Console.WriteLine("Генерируем случайный двумерный массив");
Console.WriteLine();
int[,] array = new int[3, 4];
FillArray2D(array, -10, 10);
Console.WriteLine();
Console.WriteLine($"Сумма элементов главной диагонали = {SumMain(array)}");
Console.WriteLine();

