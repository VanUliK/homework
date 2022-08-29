// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.WriteLine("Введите пятизначное число: ");
// int N = Convert.ToInt32(Console.ReadLine());


// if (N >= 10000 && N < 100000)
// {
//     int first = N.ToString()[0] - '0';
//     int second = N.ToString()[1] - '0';
//     int third = N.ToString()[2] - '0';
//     int fourth = N.ToString()[3] - '0';
//     int fifth = N.ToString()[4] - '0';
//     if (first == fifth && second == fourth)
//     {
//         Console.WriteLine($"{N} является палиндромом");
//     }
//     else
//     {
//         Console.WriteLine($"{N} не является палиндромом");
//     }
// }
// else
// {
//     Console.WriteLine("Введено некорректное число");
// }

//Другой вариант

Console.WriteLine("Введите пятизначное число: "); //ВАРИАНТ №2 - Универсальный алгоритм :)
int number = Convert.ToInt32(Console.ReadLine());
int numberLen = (int)Math.Log10(number);
int first = numberLen;
int last = 1;
int firstDigit = (int)(number / Math.Pow(10, numberLen));
int lastDigit = (number / last) % 10;

if (numberLen == 4) //Если убрать проверку этого условия, то решение будет доступно для чисел от 1 до 2,147,483,647 :)
{
    for (int i = 1; i <= ((numberLen + 1) / 2); i++)
    {
        if (firstDigit == lastDigit)
        {
            first = first - 1;
            last = last * 10;
            firstDigit = (int)(number / Math.Pow(10, first) % 10);
            lastDigit = (number / last) % 10;
        }
    }
    if (firstDigit == lastDigit)
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("нет");
    }
}
else
{
    Console.WriteLine("Значение неверно! Введите пятизначное число!");
}

// //Третий вариант

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int numbersave = number;
// int revnumber = 0;

// while (number > 0)
// {
//     int dig = number % 10;
//     revnumber = revnumber * 10 + dig;
//     number = number / 10;
// }
// if (numbersave == revnumber)
//     Console.WriteLine("Число является палиндромом");
// else
//     Console.WriteLine("Число не является палиндромом");