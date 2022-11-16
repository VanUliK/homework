// Задача 17. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// первый способ (через метод)

int GetNumberOfPlane(double x, double y)
{
    int numberOfPlane = 0;

    if (x > 0 && y > 0)
    {
        numberOfPlane = 1;
    }
    if (x < 0 && y > 0)
    {
        numberOfPlane = 2;
    }
    if (x < 0 && y < 0)
    {
        numberOfPlane = 3;
    }
    if (x > 0 && y < 0)
    {
        numberOfPlane = 4;
    }
    return numberOfPlane;
}

Console.WriteLine("Введите координаты по x");
double x = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координаты по y");
double y = double.Parse(Console.ReadLine()!);

int NumberOfPlane = GetNumberOfPlane(x, y);
Console.WriteLine(NumberOfPlane);

// второй способ

// if (x > 0 && y > 0)
// {
//     Console.WriteLine("Точка находится в первой координатной четверти");
// }
// else if (x < 0 && y > 0)
// {
//     Console.WriteLine("Точка находится во второй координатной четверти");
// }
// else if (x < 0 && y < 0)
// {
//     Console.WriteLine("Точка находится в третьей координатной четверти");
// }
// else if (x > 0 && y < 0)
// {
//     Console.WriteLine("Точка находится в четвертой координатной четверти");
// }
// else
// {
//     Console.WriteLine("Невозможно определить координатную четверть точки");
// }
