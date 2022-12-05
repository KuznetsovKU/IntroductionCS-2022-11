// S63.	Создать подпрограмму Create2DArray(m,n), которая возвращает двумерный массив следующим правилом: 
//      Aij = i+j, где i и j - индексы элементов массива, а m и n - размеры массива

int[,] Create2DArray(int rows = 4, int columns = 4)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++) matrix[i, j] = i + j;
    }
    return matrix;
}

void Print_Matrix(int[,] matrixToPrint)
{
    for(int i=0;i<matrixToPrint.GetLength(0);i++)
    {
        for(int j=0;j<matrixToPrint.GetLength(1);j++)
        {
            System.Console.Write($"{matrixToPrint[i,j]}\t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

int[,] matrix_063 = Create2DArray();
Print_Matrix(matrix_063);
