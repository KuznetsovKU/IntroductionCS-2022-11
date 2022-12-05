// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

void OrderingMatrix(int[,] inputMatrix)  // усложнил задачу. Заложил выбор вариантов сортировки
{
    System.Console.Write("Укажите что будем упорядочивать (1 - строки, 2 - столбцы). Введите цифру: ");
    string? direction = Console.ReadLine();
    System.Console.Write("Укажите как будем упорядочивать (1 - по убыванию, 2 - по возрастанию). Введите цифру: ");
    string? form = Console.ReadLine();
    int orderingType = Convert.ToInt32(direction + form);
    switch(orderingType)
    {
        case 11:
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
            break;
        }
        case 12:
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
            break;
        }
        case 21:
        {
            for (int j = 0; j < inputMatrix.GetLength(1); j++)
            {
                for (int i = 0; i < inputMatrix.GetLength(0); i++)
                {
                    for (int k = i + 1; k < inputMatrix.GetLength(1); k++)
                    {
                        if (inputMatrix[i, j] < inputMatrix[k, j]) Swap(ref inputMatrix[i, j], ref inputMatrix[k, j]);
                    }
                }
            }
            break;
        }
        case 22:
            for (int j = 0; j < inputMatrix.GetLength(1); j++)
            {
                for (int i = 0; i < inputMatrix.GetLength(0); i++)
                {
                    for (int k = i + 1; k < inputMatrix.GetLength(1); k++)
                    {
                        if (inputMatrix[i, j] > inputMatrix[k, j]) Swap(ref inputMatrix[i, j], ref inputMatrix[k, j]);
                    }
                }
            }
            break;
        default:
        {
            System.Console.WriteLine("Не правильный ввод вариантов упорядочивания");
            break;
        }
    }
}

int[,] matrix_066_A = FillRandomMatrix();
Print_Matrix(matrix_066_A);

OrderingMatrix(matrix_066_A);
Print_Matrix(matrix_066_A);
