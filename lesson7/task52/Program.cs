/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,7; 5,7; 3,7; 3.
*/

// double - результат

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

void FindArithmeticColumnMatrix(int[,] matrix)
{
    double arithmeticColumns = 0;
    int sumColumns = 0;
    int result = 0;

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sumColumns += matrix[i, 0];
        }
    }
    arithmeticColumns = sumColumns / matrix.GetLength(1);
    Console.WriteLine("сумма первого столбца = " + sumColumns/matrix.GetLength(1));
    Console.WriteLine($"Среднее арифметическое первого столбца = {arithmeticColumns/matrix.GetLength(0)}");
}

int[,] matrix = FillMatrix(4, 5);
PrintMatrix(matrix);
FindArithmeticColumnMatrix(matrix);
