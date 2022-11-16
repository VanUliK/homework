// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.WriteLine("Введите A");
int a = Convert.ToInt32(Console.ReadLine());

int sum = 0;
for (int i = 0; i < a; i++)
{
    sum = sum + i;
    //sum += i;
}
Console.WriteLine(a + sum);

// Второй вариант

int GetSum(int a)
{
    return a * (a + 1) / 2;
    // int sum = a * (a + 1) / 2;
    // return sum;
}

Console.WriteLine(GetSum(a));


