// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Задайте количество строк двумерного массива:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов двумерного массива:");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matr = new int[m, n];


CreateMatrix(matr);
FillMatrix (matr);


Console.WriteLine("Задайте количество строк двумерного массива:");
int mm = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов двумерного массива:");
int nn = Convert.ToInt32(Console.ReadLine());
int[,] matr2 = new int[mm, nn];



CreateMatrix2(matr2);
FillMatrix (matr2);




int[,] resultMatrix = new int[mm, n];

MultiplicationMatrix(matr2, matr, );
Console.WriteLine($"\nПроизведение первой и второй матриц:");
FillMatrix(multMatrix);

int  MultiplicationMatrix(int[,] martr, int[,] martr2, int[,] multMatrix)

{
  for (int i = 0; i < multMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < multMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < martr.GetLength(1); k++)
      {
        sum += martr[i,k] * martr2[k,j];
      }
      multMatrix[i,j] = sum;
    }
  }
}


void FillMatrix(int[,] matrixFill)

{
    for (int i = 0; i < matrixFill.GetLength(0); i++)
    {
        for (int j = 0; j < matrixFill.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
            Console.Write(matr[i, j] + " ");
        }
        Console.WriteLine();
    }
}



void CreateMatrix(int[,] matrix)

{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}

void CreateMatrix2(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(1,10);
    }
  }
}





