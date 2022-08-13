// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

bool CheckPolindrom (string numbers)
{
    int size = numbers.Length;
    for (int n=0; n < size/2; n++)
    {
        if (numbers[n] != numbers[size - 1 -n])
        return false;
    }
    return true;
}

Console.WriteLine("Введите пятизначное число");

if (CheckPolindrom(Console.ReadLine()) == true)
{
    Console.WriteLine("Число является полиндромом");
}
else
{
    Console.WriteLine("Число НЕ является полиндромом");
}

    


