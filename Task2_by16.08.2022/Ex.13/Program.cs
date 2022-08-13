// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine());
string str = N.ToString();
int size = str.Length;

if (size >= 3 && N > 0) Console.WriteLine(str[2]);
else if (size >= 4 && N < 0) Console.WriteLine(str[3]);
else Console.WriteLine("Третьей цифры нет");
