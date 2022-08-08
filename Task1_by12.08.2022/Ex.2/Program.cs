// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите значение числа а");
int numberA = int.Parse(Console.ReadLine());

Console.WriteLine("Введите значение числа b");
int numberB = int.Parse(Console.ReadLine());  

if (numberA > numberB)
    {
    Console.WriteLine("max = " + numberA);
    }
if (numberA < numberB)
    {
    Console.WriteLine("max = " + numberB);
    }
if (numberA == numberB)
    {
    Console.WriteLine("Числа равны");
    }       
        
    