// (Рекурии) Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int InputNaturalNumber()
{
    string input = Console.ReadLine();
    if (!int.TryParse(input, out int number) || number < 1)
    {
        Console.WriteLine("Ошибка! Введите натуральное число ");
        return InputNaturalNumber();
    }
    return number;
}

Console.Clear();
Console.WriteLine("Введите значения M и N: ");
Console.Write("M = ");
int M = InputNaturalNumber();
Console.Write("N = ");
int N = InputNaturalNumber();
int sum = 0;

int SummNaturals(int M, int N)
{
    if (M <= N)
    {
        sum = sum + M;
        SummNaturals(M + 1, N);
    }
    return sum;
}

sum += SummNaturals(M,N);
Console.WriteLine($"Сумма натуральных элементов в промежутке от {M} до {N} = {sum}");
Console.WriteLine();