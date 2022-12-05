// 68.	Написать программу, которая обменивает элементы первой строки и последней строки

int[,] FillRandomMatrix(int rows = 3, int columns = 5, int min = -10, int max = 10)
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

void Swap(ref int arg1, ref int arg2)
{
    int temp = arg1;
    arg1 = arg2;
    arg2 = temp;
}

void ChangeRows(int[,] inputMatrix)
{
    for (int j = 0; j < inputMatrix.GetLength(1); j++) Swap(ref inputMatrix[0, j], ref inputMatrix[inputMatrix.GetLength(0) - 1, j]);
}

int[,] matrix_068 = FillRandomMatrix();
Print_Matrix(matrix_068);
ChangeRows(matrix_068);
Print_Matrix(matrix_068);
