// 97. В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.

int[,] FillRandom2DArray(int rows, int columns, int min = 0, int max = 100)
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

int[] FindIndexMinInMatrix(int[,] inputMatrix)
{
    int[] indexMin = new int[2];
    int min = inputMatrix[0, 0];
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            if (inputMatrix[i, j] < min)
            {
                min = inputMatrix[i, j];
                indexMin[0] = i;
                indexMin[1] = j;
            }
        }
    }
    return indexMin;
}

int[,] DelCrossWihtMin(int[,] inputMatrix)
{
    int[] key = FindIndexMinInMatrix(inputMatrix);
    int[,] outputMatrix = new int[inputMatrix.GetLength(0) - 1, inputMatrix.GetLength(1) - 1];
    for (int i = 0; i < outputMatrix.GetLength(0); i++)
    {
        int a = i >= key[0] ? i + 1 : i;  // вводим a = i. если a >= key[0] то a = i + 1, иначе a = i (Оператор ?: — тернарный условный оператор)
        for (int j = 0; j < outputMatrix.GetLength(1); j++)
        {
            int b = j >= key[1] ? j + 1 :j;  // вводим b = j. если b >= key[1] то b = j + 1, иначе b = j (Оператор ?: — тернарный условный оператор)
            outputMatrix[i, j] = inputMatrix[a, b];
        }
    }
    return outputMatrix;
}

int[,] matrix_97 = FillRandom2DArray(3, 3);
Print2DArray(matrix_97);
int[,] matrix_97A = DelCrossWihtMin(matrix_97);
Print2DArray(matrix_97A);