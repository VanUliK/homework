void PrintArray(double[] arr)
{
    int count = arr.Length;
    int index = 0;
    while (index < count)
    {
        Console.Write($"{arr[index]:f2} ");
        index++;
    }
}
// Console.WriteLine("Задайте размер массива со случайными числами: ");
// int arrLen = Convert.ToInt32(Console.ReadLine());
int arrLen = 5;
// Console.WriteLine("Введите минимально возможное значение элемента массива: ");
// double minArrValue = Convert.ToDouble(Console.ReadLine());
double minArrValue = 0;
// Console.WriteLine("Введите максимально возможное значение элемента массива: ");
// double maxArrValue = Convert.ToDouble(Console.ReadLine());
double maxArrValue = 10;
double[] arr = new double[arrLen];
Random rand = new Random();
int i = 0;
arr[i] = rand.NextDouble() * (maxArrValue - minArrValue) + minArrValue;
double maxValue = arr[0];
double minValue = arr[0];
for (i = 1; i < arr.Length; i++)
{
    arr[i] = rand.NextDouble() * (maxArrValue - minArrValue) + minArrValue;
    if (arr[i] > maxValue)
    {
        maxValue = arr[i];
    }
    else if (arr[i] < minValue)
        {
            minValue = arr[i];
        }
}
double diff = maxValue - minValue;
Console.WriteLine(" ");
Console.WriteLine("*Ответ*");
Console.WriteLine($"Разница между максимальным ({maxValue:f2}) и минимальным ({minValue:f2}) элементом массива [] составляет {diff:f2}");
//Console.Write($"{string.Join(", ", array.Select(x => Math.Round(x, 2)))}");

PrintArray(arr);
