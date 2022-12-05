// 66.	Написать подпрограмму, которая в матрице чисел находит сумму элементов главной диагонали

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

int CountMainDiagonalElementsSum(int[,] inputMatrix)
{
    int summ = 0;
    int rows = inputMatrix.GetLength(0);
    int columns = inputMatrix.GetLength(1);
    if (rows != columns) throw new ArgumentException("Сумма элементов главной диагонали не определена: Матрица не квадратная");
    for (int i = 0; i < rows; i++) summ += inputMatrix[i,i];
    return summ;
}

int[,] matrix_066 = FillMatrix();
PrintMatrix(matrix_066);
System.Console.WriteLine($"Сумма элементов главной диагонали: {CountMainDiagonalElementsSum(matrix_066)}");