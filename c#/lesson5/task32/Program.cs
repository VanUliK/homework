// Задача 32: Напишите программу замена элементов массива: положительные элементы замените
// на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

//Первый вариант (оптимизированный)
int[] array = new int[12];
Random rand = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(-9, 10);
    Console.Write(array[i] + " ");
    array[i] *= -1;
}
Console.WriteLine(" ");
Console.WriteLine(string.Join(", ", array));


// Второй вариант

// Console.WriteLine("Введите колличество элементов массива:");
// int A = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[A];
// Random rand = new Random();

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = rand.Next(-99, 100);
// }
// Console.WriteLine(string.Join(", ", array));

// for (int i = 0; i < array.Length; i++)
// {
//     //array[i] = array[i] * -1;
//     array[i] *= -1;
//     //array[i] = - array[i];
// }
// Console.WriteLine(string.Join(", ", array));



