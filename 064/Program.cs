// 64.	В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты по значению.


int[,] FillMatrix(int rows = 4, int columns = 4, int min = -10, int max = 10)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrixToPrint)
{
    for (int i = 0; i < matrixToPrint.GetLength(0); i++)
    {
        for (int j = 0; j < matrixToPrint.GetLength(1); j++)
        {
            System.Console.Write($"{matrixToPrint[i, j]}\t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

int[,] ChangeSpecificElemets(int[,] inputMatrix)  // без создания новой матрицы
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0) inputMatrix[i,j] *= inputMatrix[i, j];
        }
    }
    return inputMatrix;
}

int[,] matrix_064 = FillMatrix();
PrintMatrix(matrix_064);
ChangeSpecificElemets(matrix_064);
PrintMatrix(matrix_064);
