// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] FillArray(double[] array)
{
    for(int i=0; i < array.Length; i++)
    {
        array[i] = Math.Round(new Random().NextDouble()*20-10, 2);
    }
    Console.Write(String.Join(" ", array));
    return array;
}

Console.Clear();
double[] array = new double[8];
Console.WriteLine("Генерируем массив заполненный случайными вещественными числами от -10 до 10...");
FillArray(array);
double min = array.Min();
double max = array.Max();
Console.WriteLine();
Console.WriteLine($"Минимальный элемент массива = {min}");
Console.WriteLine($"Максимальный элемент массива = {max}");
Console.WriteLine($"Разница между максимальным и минимальным элементом = {Math.Round(max-min, 2)}");
Console.WriteLine();