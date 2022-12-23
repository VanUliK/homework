// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100 & number < 1000)
{
  int res = number / 10;
  int res1 = res % 10;
  Console.WriteLine($"Вторая цифра числа {number} - {res1}");
}
else
{
  Console.WriteLine("Введено некорректное число");
}
