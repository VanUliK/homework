// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Вводим массив через консоль

//Console.WriteLine(string.Join(", ", arr)); - вывод массива одной строкой


// void FillArray(int[] array)
// {
//     int length = array.Length;
//     int index = 0;
//     while (index < length)
//     {
//         Console.WriteLine($"Введите элемент массива [{index}]:");
//         int N = Convert.ToInt32(Console.ReadLine());
//         array[index] = N;
//         index++;
//     }
// }
// void PrintArray(int[] arr)
// {
//     int count = arr.Length;
//     int index = 0;
//     while (index < count)
//     {
//         Console.Write(arr[index] + " ");
//         index++;
//     }
// }
// int[] array = new int[8];
// int count = array.Length;

// FillArray(array);
// PrintArray(array);

// Второй способ

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] arr = new int[8];

Console.WriteLine("Введите 8 (Восемь) целых чисел для создания массива");

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Вы создали массив:");
Console.Write(string.Join(", ", arr));
