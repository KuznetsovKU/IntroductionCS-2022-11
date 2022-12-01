// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] FillRandomMatrix(int rows = 5, int columns = 5, int min = -10, int max = 10)
{
    int[,] outputMatrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            outputMatrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return outputMatrix;
}

void Print_Matrix(int[,] matrixToPrint)
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

void FindMinRow(int[,] inputMatrix)
{
    int[] rows = new int[inputMatrix.GetLength(0)];
    int minRowNumber = 0;
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            sum += inputMatrix[i, j];
        }
        rows[i] = sum;
    }
    for (int i = 0; i < rows.Length; i++)
    {
        if (rows[i] < rows[minRowNumber]) minRowNumber = i;
    }
    System.Console.WriteLine($"Строка с наименьшей суммой элементов: {minRowNumber}");
}

int[,] matrix_068_A = FillRandomMatrix();
Print_Matrix(matrix_068_A);
FindMinRow(matrix_068_A);