Console.WriteLine("\nВведите размер строки и столбца для заполнения квадратной матрицы по спирали: ");
int numUser = Convert.ToInt32(Console.ReadLine());
int[,] spiralMatrix2 = SpiralMatrix(numUser);
PrintMatrix(spiralMatrix2);






void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3} | ");
            else Console.Write($"{matrix[i, j],3} ");
        }
        Console.WriteLine("|");
    }
}

int[,] SpiralMatrix(int num)
{
    int[,] spiralMatrix = new int[num, num];
    int temp = 1;
    int i = 0;
    int j = 0;
    while (temp <= spiralMatrix.GetLength(0) * spiralMatrix.GetLength(1))
    {
        spiralMatrix[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < spiralMatrix.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= spiralMatrix.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > spiralMatrix.GetLength(1) - 1)
            j--;
        else
            i--;
    }
    return spiralMatrix;
}



