// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int Akkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (m > 0 && n == 0)
        return Akkerman(m - 1, 1);
    else if (m > 0 && n > 0)
        return Akkerman(m - 1, Akkerman(m, n - 1));
    else
        return 0;
}

int InputNumber()
{
    string input = Console.ReadLine();
    if (!int.TryParse(input, out int number) || number < 0)
    {
        Console.WriteLine("Ошибка! Введите корректное число ");
        return InputNumber();
    }
    return number;
}

Console.Clear();
Console.WriteLine("Введите два неотрицательных числа M и N: ");
Console.Write("M = ");
int m = InputNumber();
Console.Write("N = ");
int n = InputNumber();

switch (m)
{
    case 0:
        int result = Akkerman(m, n);
        Console.WriteLine($"Akkerman({m},{n}) = {result}");
        break;
    case 1:
        result = Akkerman(m, n);
        Console.WriteLine($"Akkerman({m},{n}) = {result}");
        break;
    case 2:
        if (n < 8030)
        {
            result = Akkerman(m, n);
            Console.WriteLine($"Akkerman({m},{n}) = {result}");
        }
        else Console.WriteLine("Слишком сложно!");
        break;
    case 3:
        if (n < 11)
        {
            result = Akkerman(m, n);
            Console.WriteLine($"Akkerman({m},{n}) = {result}");
        }
        else Console.WriteLine("Слишком сложно!");
        break;
    case 4:
        if (n == 0)
        {
            result = Akkerman(m, n);
            Console.WriteLine($"Akkerman({m},{n}) = {result}");
        }
        else Console.WriteLine("Слишком сложно!");
        break;
    default:
        Console.WriteLine("| Значение функции Аккермана для указаной пары M и N невозможно посчитать");
        Console.WriteLine("| с помощью простого рекурсивного применения за разумное время");
        break;
}
Console.WriteLine();