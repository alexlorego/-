// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] FillArray(int[] array)
{
    for(int i=0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
    Console.Write(String.Join(" ", array));
    return array;
}

int[] array = new int[8];
Console.WriteLine("Генерируем случайный массив из 8 элементов...");
FillArray(array);
Console.WriteLine();