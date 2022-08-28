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
int[,] matrix = new int[,] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
PrintMatrix(matrix);

double arithmeticColumns = 0;
int temp = 0;
double sumColumns = 0;
double result = 0;

for (int j = 0; j < matrix.GetLength(1); j++)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        temp += matrix[i, j];
        //  Console.Write(matrix[0, j]);
    }
    
    Console.WriteLine(temp);
    temp = 0;
}

            sumColumns += matrix[i, j];
        }
        arithmeticColumns = sumColumns / matrix.GetLength(0);
        Console.Write($"Сумма {j + 1} столбца = {sumColumns} ");
        Console.WriteLine($" Среднеарифметическое = {arithmeticColumns:F2}");
        sumColumns = 0;
    }

Console.WriteLine(result);
sumColumns = temp / matrix.GetLength(1);
arithmeticColumns = sumColumns / matrix.GetLength(0);
Console.WriteLine("сумма первого столбца = " + sumColumns);
Console.WriteLine($"Среднее арифметическое первого столбца = {arithmeticColumns:F2}");

