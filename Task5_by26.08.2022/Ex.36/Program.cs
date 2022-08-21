// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] FillArray(int[] array)
{
    for(int i=0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
    Console.Write(String.Join(" ", array));
    return array;
}

int SumOdd(int[] array)
{
    int sum = 0;
    for(int i = 1; i < array.Length; i+=2) sum+=array[i];
    return sum;
}

Console.Clear();
int[] array = new int[4];
Console.WriteLine("Генерируем массив заполненный случайными числами...");
FillArray(array);
Console.WriteLine();
Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях = {SumOdd(array)}");
Console.WriteLine();

