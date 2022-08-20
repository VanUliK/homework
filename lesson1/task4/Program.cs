// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число c: ");
int c = Convert.ToInt32(Console.ReadLine());

// первый способ

if (a > b)
{
    if (a > c)
    {
        Console.WriteLine("Максимальное число " + a);
    }
}
else
{
    if (b > c)
    {
        Console.WriteLine("Максимальное число " + b);
    }
    else
    {
        Console.WriteLine("Максимальное число " + c);
    }
}
// второй способ

int max = a;
if (b > max)
{
    max = b;
}
if (c > max)
{
    max = c;
}
Console.WriteLine($"a = {a} b = {b} c = {c}");
Console.WriteLine($"Максимальное число - {max}");
