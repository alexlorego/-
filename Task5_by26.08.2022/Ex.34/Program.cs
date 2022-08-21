// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве

int[] FillArray(int[] array)
{
    for(int i=0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    Console.Write(String.Join(" ", array));
    return array;
}

int CountPos(int[] array)
{
    int count = 0;
    for(int i=0; i < array.Length; i++) 
    if(array[i]%2 == 0)
    {
        count++;
    }
    return count;
}

Console.Clear();
int[] array = new int[10];
Console.WriteLine("Генерируем массив заполненный случайными положительными трёхзначными числами...");
FillArray(array);
Console.WriteLine();
Console.WriteLine($"Количество четных чисел в массиве - {CountPos(array)}");
Console.WriteLine();

