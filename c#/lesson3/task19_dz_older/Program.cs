// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.

Console.Clear();

// Добавим сложности.
// Входное число рандомное от 3 до 18 знаков.

Console.WriteLine("Введите число от 3 до 18 знаков: ");
long number = Convert.ToInt64(Console.ReadLine());

int NumberLength() // Определение разрядности (длины) числа
{
    long num = number;
    int digits = 0;
    while (num > 0)
    {
        num = num / 10;
        digits++;
    }
    return digits;
}

long DigitOnAdress(int address) // Определение цифры по разряду
{
    long num = number;
    int length = NumberLength();
    while (address < length)
    {
        num = num / 10;
        address++;
    }
    long digit = num % 10;
    return digit;
}

if (number < 0) number = -number; // исключаем отрицательное значение

int increment = 1;
int decriment = NumberLength();

if (NumberLength() < 3 || NumberLength() > 18) // проверка на условие разрядности
{
    Console.WriteLine("Количество знаков в числе не соответствует условию");
}
else
{
    while (DigitOnAdress(increment) == DigitOnAdress(decriment))
    {
        increment++;
        decriment--;
    }
    if (increment > decriment)
    {
        Console.WriteLine("Палиндромом");
    }
    else
    {
        Console.WriteLine("Набор цифр");
    }
}