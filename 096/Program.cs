// Задача 96: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//            Например, заданы 2 массива:

int[,] matrix_1 = new int[,] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 }, { 5, 2, 6, 7 } };
int[,] matrix_2 = new int[,] { { 1, 5, 8, 5 }, { 4, 9, 4, 2 }, { 7, 2, 2, 6 }, { 2, 3, 4, 7 } };

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

int[,] MatrixPower(int[,] firstMatrix, int[,] secondMatrix)  // как в примере
{
    if (firstMatrix.GetLength(1) != secondMatrix.GetLength(0)) throw new ArgumentException("Матрицы не совместимы");
    else
    {
        int[,] outputMatrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
        for (int i = 0; i < outputMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < outputMatrix.GetLength(1); j++)
            {
                outputMatrix[i, j] = firstMatrix[i, j] * secondMatrix[i, j];
            }
        }
        return outputMatrix;
    }
}

int[,] CountMatrixPower(int[,] firstMatrix, int[,] secondMatrix)  // в соответствии с определением произведения
{
    if (firstMatrix.GetLength(1) != secondMatrix.GetLength(0)) throw new ArgumentException("Матрицы не совместимы");
    else
    {
        int[,] outputMatrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
        for (int i = 0; i < outputMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < outputMatrix.GetLength(1); j++)
            {
                outputMatrix[i, j] = 0;
                for (int k = 0; k < firstMatrix.GetLength(1); k++)
                {
                    outputMatrix[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
                }

            }
        }
        return outputMatrix;
    }
}

Print2DArray(matrix_1);
Print2DArray(matrix_2);
int[,] power1 = MatrixPower(matrix_1, matrix_2);
System.Console.WriteLine("Результат как в примере");
Print2DArray(power1);
int[,] power2 = CountMatrixPower(matrix_1, matrix_2);
System.Console.WriteLine("Результат как должен быть");
Print2DArray(power2);
