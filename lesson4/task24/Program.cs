// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.WriteLine("Введите A");
int A = Convert.ToInt32(Console.ReadLine());

int sum = 0;
for (int i = 0; i < A; i++)
{
    sum = sum + i;
    //sum += i;
}
Console.WriteLine(A + sum);



