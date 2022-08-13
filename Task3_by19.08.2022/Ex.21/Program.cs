// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве

Console.Write("Введите через пробел координаты первой точки А(x1,y1,z1) : ");
string[] arr1= Console.ReadLine().Split();
int x1 = int.Parse(arr1[0]);
int y1 = int.Parse(arr1[1]);
int z1 = int.Parse(arr1[2]);

Console.Write("Введите через пробел координаты второй точки B(x2,y2,z2) : ");
string[] arr2= Console.ReadLine().Split();
int x2 = int.Parse(arr2[0]);
int y2 = int.Parse(arr2[1]);
int z2 = int.Parse(arr2[2]);

double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine("Расстояние между точками А и В в пространстве равно " + Math.Round(distance, 2));
