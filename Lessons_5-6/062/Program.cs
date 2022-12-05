// 62.	В двумерном массиве n×k заменить четные элементы на противоположные по значению (a[i,j]=-a[i,j])

int[,] FillMatrix(int rows = 4, int columns = 4, int min = -100, int max = 100)
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

int[,] MirroringEven(int[,] inputMatrix)  // с созданием новой матрицы
{
    int[,] mirroredMatrix = new int[inputMatrix.GetLength(0), inputMatrix.GetLength(1)];
    for (int i = 0; i < mirroredMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < mirroredMatrix.GetLength(1); j++)
        {
            if (inputMatrix[i, j] % 2 == 0) mirroredMatrix[i,j] = -inputMatrix[i, j];
            else mirroredMatrix[i,j] = inputMatrix[i, j];
        }
    }
    return mirroredMatrix;
}

int[,] ChangeEven(int[,] inputMatrix)  // без создания новой матрицы
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            if (inputMatrix[i, j] % 2 == 0) inputMatrix[i,j] = -inputMatrix[i, j];
        }
    }
    return inputMatrix;
}

int[,] matrix_062 = FillMatrix();
PrintMatrix(matrix_062);
int[,] matrix_062_mirrored = MirroringEven(matrix_062);
PrintMatrix(matrix_062_mirrored);
ChangeEven(matrix_062);
PrintMatrix(matrix_062);
