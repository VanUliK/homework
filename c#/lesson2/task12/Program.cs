﻿// 12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деление.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int mod = number1 % number2;
if (mod == 0)
{
    Console.Write("второе число является кратным первому");
}
else
{
    
    Console.Write("второе число не является кратным первому, остаток = " + mod);

}