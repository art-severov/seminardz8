// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
//  которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] matrix2 = GenerateMatrix(5,5,0,9);
Console.WriteLine($"\nЗаданный  массив: ");
PrintMatrix(matrix2);
Console.WriteLine();


int minSumString = 0;
int sumString = SumStringElements(matrix2, 0);
for (int i = 1; i < matrix2.GetLength(0); i++)
{
  int tempSumString = SumStringElements(matrix2, i);
  if (sumString > tempSumString)
  {
    sumString = tempSumString;
    minSumString = i;
  }
}


Console.WriteLine($"\n{minSumString+1}-я - строкa с наименьшей суммой элементов. Сумма строки равна: {sumString} ");


int SumStringElements(int[,] matrix2, int i)
{
  int sumString = matrix2[i,0];
  for (int j = 1; j < matrix2.GetLength(1); j++)
  {
    sumString += matrix2[i,j];
  }
  return sumString;
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
        Console.Write("");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 3}");
            else Console.Write($"{matrix[i,j], 3} ");
        }
        Console.WriteLine("");
    }
}






