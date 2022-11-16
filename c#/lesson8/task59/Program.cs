/*Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим
следующий массив:
9 4 2
2 2 6
3 4 7
*/
Console.Clear();

int[,] FillMatrix(int rowsCount, int columnsCount, int leftRange = 0, int rightRange = 9)
{
    int[,] matrix = new int[rowsCount, columnsCount];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)

{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите число строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = FillMatrix(m, n);
PrintMatrix(matrix);
Console.WriteLine();

int min = matrix[0, 0];
int iMin = 0;
int jMin = 0;

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (matrix[i, j] < min)
        {
            min = matrix[i, j];
            iMin = i;
            jMin = j;
        }
    }
}
Console.WriteLine(min);
Console.WriteLine(iMin);
Console.WriteLine(jMin);

int[,] newMatrix = new int[m - 1, n - 1];
for (int i = 0; i < iMin; i++)
{
    for (int j = 0; j < jMin; j++)
    {
        newMatrix[i, j] = matrix[i, j];
    }
}
for (int i = iMin; i < m - 1; i++)
{
    for (int j = 0; j < jMin; j++)
    {
        newMatrix[i, j] = matrix[i + 1, j];
    }
}
for (int i = 0; i < iMin; i++)
{
    for (int j = jMin; j < n - 1; j++)
    {
        newMatrix[i, j] = matrix[i, j + 1];
    }
}
for (int i = iMin; i < m - 1; i++)
{
    for (int j = jMin; j < n - 1; j++)
    {
        newMatrix[i, j] = matrix[i + 1, j + 1];
    }
}


PrintMatrix(newMatrix);
