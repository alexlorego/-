// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа
Console.WriteLine("Введите трехзначное число");
int N = int.Parse(Console.ReadLine());
string str = N.ToString();
int size = str.Length;

if (size == 3 && N > 0) Console.WriteLine(str[1]);
else if (size == 4 && N < 0) Console.WriteLine(str[2]);
else Console.WriteLine("Введено некорректное число");
