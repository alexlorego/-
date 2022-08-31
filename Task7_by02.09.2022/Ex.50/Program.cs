// Напишите программу, которая на вход принимает число, и возвращает индексы этого элемента или же указание, что такого элемента нет.

int InputNumber()
{
    Console.WriteLine("Введите число: ");
    string input = Console.ReadLine();
    if (!int.TryParse(input, out int number))
    {
        Console.WriteLine("Ошибка ввода! Введите корректное число ");
        return InputNumber();
    }
    return number;
}

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

bool FindNumber(int[,] array, int number)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == number) return true;
        }
    }
    return false;

}

void FindIndex(int[,] array, int number)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == number) Console.Write($"[{i}, {j}]");
        }
    }

}

Console.Clear();
Console.Write("Введите через пробел кол-во строк, столбцов, мин и макс значения для генерации массива: ");
string[] inputData = Console.ReadLine().Split();
int rows = Convert.ToInt32(inputData[0]);
int columns = Convert.ToInt32(inputData[1]);
int min = Convert.ToInt32(inputData[2]);
int max = Convert.ToInt32(inputData[3]);
Console.WriteLine("Генерируем случайный двумерный массив....");
Console.WriteLine();
int[,] array = GetArray2D(rows, columns, min, max);
Console.WriteLine();
int number = InputNumber();
if (FindNumber(array, number))
{
    Console.Write($"Индексы этого элемента в сгенерированном массиве -> ");
    FindIndex(array, number);
    Console.WriteLine();
}
else Console.WriteLine("Такого элемента нет в сгенерированном массиве");
Console.WriteLine();
