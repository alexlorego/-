// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите три числа через пробел");
var nums = Console.ReadLine().Split(' ').Select(e => Convert.ToInt32(e)).ToArray();
 
int maxN = nums[0];
if (nums[0] < nums[1]) maxN = nums[1];
if (nums[1] < nums[2]) maxN = nums[2];

Console.WriteLine("Максимальное число " + maxN);