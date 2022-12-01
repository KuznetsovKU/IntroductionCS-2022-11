// 67.	Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

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

void FindAverageInColumns(int[,] inputMatrix)
{
    System.Console.WriteLine("Среднее арифметическое по столбцам:");
    double rows = inputMatrix.GetLength(0);
    double[] average = new double[inputMatrix.GetLength(1)];
    for (int j = 0; j < inputMatrix.GetLength(1); j++)
    {
        int summ = 0;
        for (int i = 0; i < inputMatrix.GetLength(0); i++)
        {
            summ += inputMatrix[i, j];
        }
        average[j] = Math.Round((Convert.ToDouble(summ) / rows), 2);
    }
    foreach (double el in average) System.Console.Write($"{el}\t");
}

int[,] matrix_067 = FillRandomMatrix();
Print_Matrix(matrix_067);
FindAverageInColumns(matrix_067);