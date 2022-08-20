// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// i = 1, i+=2

int[] array = new int[6];
Random rand = new Random();
int res = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(-9, 10);
}
for (int i = 1; i < array.Length; i += 2)
{
    res = array[i] + res;
}
Console.WriteLine(string.Join(", ", array));
Console.WriteLine($"Сумма элементов array[1], [3], [5] = {res}");