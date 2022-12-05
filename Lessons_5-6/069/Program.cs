// 69.	Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.

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

void Swap(ref int arg1, ref int arg2)
{
    int temp = arg1;
    arg1 = arg2;
    arg2 = temp;
}

int[,] OrderingRows(int[,] inputMatrix, string form = "tomin")
{
    if (form == "tomin")
    {
        for (int i = 0; i < inputMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < inputMatrix.GetLength(1); j++)
            {
                for (int k = j + 1; k < inputMatrix.GetLength(1); k++)
                {
                    if (inputMatrix[i, j] < inputMatrix[i, k]) Swap(ref inputMatrix[i, j], ref inputMatrix[i, k]);
                }
            }
        }
    }
    else if (form == "tomax")
    {
        for (int i = 0; i < inputMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < inputMatrix.GetLength(1); j++)
            {
                for (int k = j + 1; k < inputMatrix.GetLength(1); k++)
                {
                    if (inputMatrix[i, j] > inputMatrix[i, k]) Swap(ref inputMatrix[i, j], ref inputMatrix[i, k]);
                }
            }
        }
    }
    else throw new ArgumentException("Не корректно задано направление сортировки!");
    return inputMatrix;
}

int[,] matrix_069 = FillRandomMatrix();
Print_Matrix(matrix_069);

OrderingRows(matrix_069, "tomin");
Print_Matrix(matrix_069);