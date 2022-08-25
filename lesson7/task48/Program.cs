/*
Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится
по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5
*/

int[,] FillMatrix(int rowsCount, int columnsCount)
{
    int[,] matrix = new int[rowsCount, columnsCount];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i + j;
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
int m = Convert.ToInt32(Console.ReadLine());//
Console.WriteLine("Введите число столбцов");
int n = Convert.ToInt32(Console.ReadLine());//
int[,] matrix = FillMatrix(m, n);
PrintMatrix(matrix);