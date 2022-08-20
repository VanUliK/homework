// Задача 20
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2

Console.WriteLine("Введите координаты точки A по x");
double xA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты точки A по y");
double yA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты точки A по z");
double zA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты точки B по x");
double xB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты точки B по y");
double yB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты точки B по z");
double zB = Convert.ToDouble(Console.ReadLine());

double res = Math.Sqrt(Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2) + Math.Pow(zB - zA, 2));

Console.WriteLine($"{res:f2}");
