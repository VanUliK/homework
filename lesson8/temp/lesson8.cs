// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

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

//task 53
void SwapFirstAndLastRows(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int temp = matrix[0, j];
        matrix[0, j] = matrix[matrix.GetLength(0) - 1, j];
        matrix[matrix.GetLength(0) - 1, j] = temp;
    }
}

//task 55
int[,] TransposeMatrix(int[,] matrix)
{
    int[,] newMatrix = new int[matrix.GetLength(1), matrix.GetLength(0)];

    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            newMatrix[i, j] = matrix[j, i];
        }
    }
    return newMatrix;
}

//task 57
void PrintRepeatsOfElements(int[,] matrix)
{
    int[] repeats = new int[10];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            repeats[matrix[i, j]]++;
        }
    }

    for (int i = 0; i < repeats.Length; i++)
    {
        if (repeats[i] > 0)
        {
            Console.WriteLine($"Количество повторений {i} = {repeats[i]}");
        }
    }
}

//task 59
int[,] DeleteIntersectionByMinElement(int[,] matrix)
{
    int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];

    int minElement = matrix[0, 0];
    int minRow = 0;
    int minColumn = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < minElement)
            {
                minElement = matrix[i, j];
                minRow = i;
                minColumn = j;
            }
        }
    }

    int rowOffset = 0;
    int columnOffset = 0;

    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        if (i == minRow) rowOffset++;
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            if (j == minColumn) columnOffset++;
            newMatrix[i,j] = matrix[i + rowOffset, j + columnOffset];
        }
        columnOffset = 0;
    }
    return newMatrix;
}


Console.Write("Введите m и n через Enter "); 
int m = Convert.ToInt32(Console.ReadLine());//число строк
int n = Convert.ToInt32(Console.ReadLine());//число столбцов
int[,] matrix = FillMatrix(m, n);
PrintMatrix(matrix);
Console.WriteLine();
int[,] newMatrix = DeleteIntersectionByMinElement(matrix);
PrintMatrix(newMatrix);

