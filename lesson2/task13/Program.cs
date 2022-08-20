// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int digitIndex = 2; // индекс нужной цифры

if (number < 0)
{
    number = -number;
}

// Первый вариант решения

if (number > 100)
{
    int digit = number.ToString()[digitIndex] - '0';
    Console.WriteLine("Третья цифра " + digit + " //первым способом");
}
else
{
    Console.WriteLine($"Во введенном числе {number} нет третьей цифры");
}

// Второй вариант решения

if (number > 100)
{
    while (number >= 1000)
    {
        number /= 10;   // number = number / 10;
    }
    int res = number % 10;
    Console.WriteLine("Третья цифра " + res + " //вторым способом");
}
else
{
    Console.WriteLine($"Во введенном числе {number} нет третьей цифры");
}

// Третий вариант решения

// Console.WriteLine("Введите число: ");
// string number3 = Console.ReadLine();
// if (number3.Length > 0)
// {
//     if (number3[0] == '-')
//     {
//         digitIndex++;
//     }

// }
// if (number3.Length <= digitIndex)
// {
//     Console.WriteLine($"нет третьей цифры в {number3}");
// }
// else
// {
//     Console.WriteLine($"Третья цифра {number3[digitIndex]} //третьим способом");
// }