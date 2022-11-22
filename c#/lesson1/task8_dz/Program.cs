// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int counter = 2;

while (counter <= N)
{
    Console.Write(counter + " ");
    counter = counter + 2;
}

// Console.Write("Введите 1е число > ");                  // Вывод приглашения ввода
// string inputnum_A = Console.ReadLine();                // Ввод строки с терминала (консоли)
// int num_A = Convert.ToInt32(inputnum_A);               // Преобразование строки в число
// Console.WriteLine("Чётные числа от 1 до " + num_A);
// int i = 2;
// bool not = true;
// while (i <= num_A)
// {

//     Console.Write(i + ", ");
//     not = false;
//     i += 2;
// }

// if (not)
// {
//     Console.WriteLine("Нет чётных чисел!");
// }