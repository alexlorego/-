// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int POWER(int A, int B)
{
    int Result = A;
    for(int count = 2; count <= B; count++)
    {
        Result = Result*A;
    }
    return Result;
}

Console.WriteLine("Введите через пробел число А и В");
string[] arr= Console.ReadLine().Split();
int A = int.Parse(arr[0]);
int B = int.Parse(arr[1]);

if (B>0)
{
    Console.WriteLine("Число А в степень В рано " + POWER(A, B));
    Console.WriteLine();
}
else
{
    Console.WriteLine("Ошибка ввода! Число В должно быть натуральным");
    Console.WriteLine();
}