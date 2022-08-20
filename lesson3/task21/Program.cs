// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21
// √(xb - xa)2 + (yb - ya)2

// Console.ReadLine().Split().Select(Convert.ToInt32).ToArray();


Console.WriteLine("Введите координаты точки A по x");
double xA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты точки A по y");
double yA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты точки B по x");
double xB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты точки B по y");
double yB = Convert.ToDouble(Console.ReadLine());

double res = Math.Sqrt(Math.Pow(xA - xB, 2) + Math.Pow(yA - yB, 2));

Console.WriteLine($"{res:f2}");