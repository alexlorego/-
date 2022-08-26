// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

Console.Clear();
Console.WriteLine("Прямые заданы уравнениями y = k1 * x + b1, y = k2 * x + b2");
Console.Write("Введите через пробел значения b1, k1, b2 и k2 : ");
string[] array= Console.ReadLine().Split();
double b1 = Convert.ToDouble(array[0]);
double k1 = Convert.ToDouble(array[1]);
double b2 = Convert.ToDouble(array[2]);
double k2 = Convert.ToDouble(array[3]);

double x;
double y;

x = Math.Round((b2-b1)/(k1-k2), 2);
y = Math.Round(k1*((b2-b1)/(k1-k2))+b1, 2);
Console.WriteLine($"Точка пересечения двух прямых -> ({x}; {y})");
Console.WriteLine();