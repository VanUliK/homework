// Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());

// Первый вариант
for (int i = 1; i <= N; i++)
{
    Console.WriteLine(i * i + " ");
}

// Второй вариант
string result = "";
for (int i = 1; i <= N; i++)
{
    double res = Math.Pow(i, 2);
    result = result + res + " | ";
}
Console.WriteLine(result);