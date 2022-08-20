// Задача 9. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8


// int number = new Random().Next(10, 100);
Random rand = new Random();
int number = rand.Next(11, 23);
Console.WriteLine(number);
int digit2 = number % 10;
int digit1 = number / 10;
if (digit1>digit2)
{
    Console.Write(digit1);
      Console.WriteLine(" наибольшая цифра");
}
else if (digit2>digit1)
{
    Console.Write(digit2);
      Console.WriteLine(" наибольшая цифра");
}
else
{
    Console.Write("Цифры равны");
}
  

