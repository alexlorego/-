// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine());

int numbers = 1;
while (numbers <= N)
{
    if (numbers%2==0)
    {
        Console.Write(numbers + " ");
    }
    numbers++;
}
