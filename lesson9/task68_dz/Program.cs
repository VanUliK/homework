/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.

m = 2, n = 3 -> A(m,n) = 9
*/

Console.WriteLine("Введите число M");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberM >= 0 && numberN >= 0)
{
    int sum = SumCountFromMToN(numberN, numberM);
    Console.WriteLine(sum);
}
else
{
    Console.WriteLine("Число M и N не могут быть отрицательными");
}

int SumCountFromMToN(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (m > 0 && n == 0)
    {
        return SumCountFromMToN(m - 1, 1);
    }
    else
    {
        return SumCountFromMToN(m - 1, SumCountFromMToN(m, n - 1));
    }
}