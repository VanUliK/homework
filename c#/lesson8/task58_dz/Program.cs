/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
Console.Clear();

int[,] FillMatrix(int rowsCount, int columnsCount, int leftRange = 0, int rightRange = 10)
{
  int[,] matrix = new int[rowsCount, columnsCount];
  Random rand = new Random();
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = rand.Next(leftRange, rightRange);
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

int[,] firstMatrix = FillMatrix(m, n);
int[,] secondMatrix = FillMatrix(m, n);

Console.WriteLine($"Первая матрица ");
PrintMatrix(firstMatrix);
Console.WriteLine($"Вторая матрица ");
PrintMatrix(secondMatrix);
Console.WriteLine($"Произведение индексов первой и второй матрицы ");

int[,] multiMatrix = multiMatrix = new int[m, n];
for (int i = 0; i < multiMatrix.GetLength(0); i++)
{
  for (int j = 0; j < multiMatrix.GetLength(1); j++)
  {
    multiMatrix[i, j] = firstMatrix[i, j] * secondMatrix[i, j];
  };
}

PrintMatrix(multiMatrix);