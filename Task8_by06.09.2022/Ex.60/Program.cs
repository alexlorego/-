// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[] NumbersPull(int from, int to)
{
    int[] numbersPull = new int[to - from + 1];
    for (int i = 0; i < numbersPull.Length; i++)
    {
        numbersPull[i] = from + i;
    }
    return numbersPull;
}

int[] ShuffleArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int rolldice = new Random().Next(0, array.Length);
        int temp = array[i];
        array[i] = array[rolldice];
        array[rolldice] = temp;
    }
    return array;
}

Console.Clear();
int[] random10to99 = ShuffleArray((NumbersPull(10, 99)));
Console.WriteLine("Генерируем массив 2 x 2 x 2");
Console.WriteLine();
int[,,] array3d = new int[2, 2, 2];
int element = 0;
for (int i = 0; i < array3d.GetLength(0); i++)
{
    for (int j = 0; j < array3d.GetLength(1); j++)
    {
        for (int k = 0; k < array3d.GetLength(2); k++)
        {
            array3d[i, j, k] = random10to99[element];
            element++;
            Console.Write($"{array3d[i,j,k]}({i},{j},{k}) ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine();




