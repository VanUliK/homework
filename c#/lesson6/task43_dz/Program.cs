// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("значения b1");
double b1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("значения k1");
double k1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("значения b2");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("значения k2");
double k2 = Convert.ToDouble(Console.ReadLine());
double point1 = (b2 - b1) / (k1 - k2);
double point2 = (k1 * b2 - k2 * b1) / (k1 - k2);

if (k1 != k2)
{
    Console.WriteLine("");
    Console.WriteLine($"прямые имеют точку пересечения ({point1:f2} ; {point2:f2})");
}
else
{
    if (b1 == b2)
    {
        Console.WriteLine("прямые совпадают, а не являются параллельными");
    }
    else
    {
        Console.WriteLine("прямые параллельны");
    }
}
