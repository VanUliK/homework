// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите число N:");
int N = Convert.ToInt32(Console.ReadLine());
int res = 1;
int i;

for (i = 1; i <= N; i++)
{
    //N = 1 2 3 4 5
    // 1*1 1*2 1*3 1*4 1*5
    res = i * res;
}

Console.WriteLine(res);
