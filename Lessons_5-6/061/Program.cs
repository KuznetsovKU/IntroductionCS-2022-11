// 61.	Показать двумерный массив размером m×n заполненный вещественными случайными числами

System.Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

double[,] FillMatrix(int rows, int columns)  // аргументы Мин и Макс исключаем с соответствии с алгоритмом метода NextDouble
{
    double[,] matrix = new double[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(new Random().NextDouble(), 2);
        }
    }
    return matrix;
}

void PrintMatrix(double [,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            System.Console.Write($"{inputMatrix[i,j]}\t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

double[,] matrix_060 = FillMatrix(rows, columns);
PrintMatrix(matrix_060);
