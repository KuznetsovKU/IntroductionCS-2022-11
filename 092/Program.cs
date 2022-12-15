// 92. Написать программу, которая в двумерном массиве заменяет строки на столбцы 
//     или сообщить, что это невозможно (в случае, если матрица не квадратная).

int[,] FillRandom2DArray(int rows, int columns, int min = 0, int max = 10)
{
    int[,] array2D = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++) array2D[i, j] = new Random().Next(min, max + 1);
    }
    return array2D;
}

void Print2DArray(int[,] arrayToPrint)
{
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            System.Console.Write($"{arrayToPrint[i, j]}\t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

int[,] TurnMatrix(int[,] inputMatrix)
{
    if (inputMatrix.GetLength(0) != inputMatrix.GetLength(1)) throw new ArgumentException("Матрица не квадратная");
    else
    {
        int[,] turnedMatrix = new int[inputMatrix.GetLength(1), inputMatrix.GetLength(0)];
        for (int i = 0; i < turnedMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < turnedMatrix.GetLength(1); j++) turnedMatrix[i, j] = inputMatrix[j, i];
        }
        return turnedMatrix;
    }
}

int[,] matrix_92 = FillRandom2DArray(5, 5);
Print2DArray(matrix_92);
int[,] matrixTurned = TurnMatrix(matrix_92);
Print2DArray(matrixTurned);
