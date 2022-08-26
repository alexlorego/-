// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Clear();
Console.Write("Введите через пробел M чисел: ");
var numbers = Console.ReadLine().Split(' ').Select(e => Convert.ToInt32(e)).ToArray();
int count = 0;
for (int i = 0; i < numbers.Length; i++) if (numbers[i] > 0) count++;
Console.WriteLine($"Количество чисел больше 0 -> {count}");
Console.WriteLine();