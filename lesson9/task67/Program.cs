/*
Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9
*/


Console.WriteLine("Введите число N");
int number = Convert.ToInt32(Console.ReadLine());

int sum = PrintNumbersToN(number);
Console.WriteLine(sum);
int PrintNumbersToN(int n)
{
    // int count = 0;
    if (n <= 0) return 0;
    // count = n % 10;
    // n = n / 10;
    // return count + PrintNumbersToN(n);
    return n % 10 + PrintNumbersToN(n / 10);

}