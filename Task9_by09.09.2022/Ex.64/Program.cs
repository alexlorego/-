// (Рекурсии) Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

void NaturalNumber(int first, int last)
{
    if (first < 1 || last < 1) 
    {
        Console.WriteLine("Ошибка ввода! M и N должны быть натуральными числами");
        return;
    }
    if (first > last) 
    {
        Console.WriteLine("Ошибка ввода! M должно быть меньше N ");
        return;
    }
    if (first < last)
    {
        Console.Write($"{first},");
        NaturalNumber(first + 1, last);
    }
    if (first == last) Console.Write($"{last}");
}

Console.Clear();
Console.WriteLine("Введите значения M и N: ");
Console.Write("M = ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("N = ");
int N = Convert.ToInt32(Console.ReadLine());
NaturalNumber(M, N);
Console.WriteLine();
