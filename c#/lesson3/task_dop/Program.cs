// Доп. задача
// Написать программу для разворота массива
void PrintArray(int[] arr)
{
  int count = arr.Length;
  int index = 0;
  while (index < count)
  {
    Console.Write(arr[index] + " ");
    index++;
  }
}
int[] arr = { 48, 75, 13, 94, 50, 14 };
int N = arr.Length;
PrintArray(arr);
Console.WriteLine();
// var str = string.Join(" ", arr);
// Console.WriteLine(str);
//
for (int i = 0; i < N / 2; i++)
{
  int temp = arr[i];
  arr[i] = arr[N - i - 1];
  arr[N - i - 1] = temp;
}

PrintArray(arr);

// Вариант без использования метода

// int[] arr = { 8, 2, 4, 4, 5 };
// int N = arr.Length;
// for (int i = 0; i < N / 2; i++)
// {
//     int temp = arr[i];
//     arr[i] = arr[N - i - 1];
//     arr[N - i - 1] = temp;
// }
// for (int index = 0; index < N; index++)
// {
//     Console.Write(arr[index] + " ");
// }

// вариант с использованием двух методов

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
// void ReverseArray(int[] array)
// {
//     int N = array.Length;
//     for (int i = 0; i < N / 2; i++)
//     {
//         int temp = array[i];
//         array[i] = array[N - i - 1];
//         array[N - i - 1] = temp;
//     }
// }
// int[] arr = { 1, 8, 3, 6, 5 };
// ReverseArray(arr);
// PrintArray(arr);