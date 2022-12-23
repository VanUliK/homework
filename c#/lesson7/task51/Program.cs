/*Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали 
(с индексами (0,0); (1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12
*/

int[,] FillMatrix(int rowsCount, int columnsCount, int leftRange = 0, int rightRange = 10)
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

int sum = 0;

for (int i = 0; i < matrix.GetLength(0); i++)
{

  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    if (i == j)
    {
      sum += matrix[i, j];
    }
  }
}

/* Решение в один цикл

int sum = 0;
int min = m;
if (n < min)
{
    min = n;
}
for (int i = 0; i < min; i++)
{
         sum += matrix[i,i] ;
}
*/

PrintMatrix(matrix);
Console.WriteLine();
Console.WriteLine(sum);


