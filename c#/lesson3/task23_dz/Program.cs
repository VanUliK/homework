﻿// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число N");
double N = Convert.ToDouble(Console.ReadLine());

for (int i = 1; i <= N; i++)
{
    double result = Math.Pow(i, 3);
    Console.WriteLine(result);
}