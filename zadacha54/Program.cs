// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


int[,] matrix2 = GenerateMatrix(3,3,0,10);
Console.WriteLine($"\nЗаданный  массив: ");
PrintMatrix(matrix2);
Console.WriteLine();
Console.WriteLine($"\nОтсортированный массив: ");
SortedMatrixDescending(matrix2);
PrintMatrix(matrix2);


void SortedMatrixDescending(int[,] matrix2)
{
  for (int i = 0; i < matrix2.GetLength(0); i++)
  {
    for (int j = 0; j < matrix2.GetLength(1); j++)
    {
      for (int k = 0; k < matrix2.GetLength(1) - 1; k++)
      {
        if (matrix2[i, k] < matrix2[i, k + 1])
        {
          int temp = matrix2[i, k + 1];
          matrix2[i, k + 1] = matrix2[i, k];
          matrix2[i, k] = temp;
        }
      }
    }
  }
}

int[,] GenerateMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns]; // 0, 1
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}



void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 3} | ");
            else Console.Write($"{matrix[i,j], 3} ");
        }
        Console.WriteLine("|");
    }
}


