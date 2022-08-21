// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int VER(string input)
{
    bool  result = Int32.TryParse(input, out int number);
    if (result == false) Console.WriteLine("Ошибка ввода! Введите корректное число");
    return number;
}

Console.WriteLine("Введите положительное число");
int number = VER(Console.ReadLine());
int sum = 0;
for (int i = number; i > 0; i /= 10)
{
   sum = sum + i % 10;
} 
    
Console.WriteLine($"Сумма цифр в числе равна {sum}");
Console.WriteLine("");
