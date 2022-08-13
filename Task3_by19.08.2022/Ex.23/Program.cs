// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N
Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine()); 
if (N >= 1)
{
    for (int i = 1; i <= N; i++)
    {
    Console.Write(Math.Pow(i, 3) +" ");
    }
    Console.WriteLine();
}
else
{
    Console.WriteLine("Ошибка! Введите корректное значение N");
    Console.WriteLine();
}