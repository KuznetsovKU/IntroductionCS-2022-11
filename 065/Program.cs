// 65.	 Написать подпрограмму, поиска элемента в двумерном массиве, подпрограмма возвращает позицию числа. 
//       Если элемент отсутствует, подпрограмма возвращает -1.

int[,] FillRandomMatrix(int rows = 5, int columns = 5, int min = -10, int max = 10)
{
    int[,] outputMatrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++) outputMatrix[i, j] = new Random().Next(min, max + 1);
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

string FindElement(int[,] inputMatrix, int requestedElement)  // пока не нашел иного способа вернуть индекс двумерного массива через return
{
    int inclusionsCount = 0;
    string inclusions = string.Empty;
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            if (inputMatrix[i,j] == requestedElement)
            {
                inclusions += $"[{i},{j}]\t";
                inclusionsCount++;
            }
        }
    }
    if (inclusionsCount == 0) inclusions = "Искомый элемент не найден";  // вместо вывода "-1"
    else inclusions = "Искомый элемент встречается на позициях: " + inclusions;
    return inclusions;
}

int[,] matrix_065 = FillRandomMatrix();
Print_Matrix(matrix_065);
FindElement(matrix_065,10);
System.Console.WriteLine(FindElement(matrix_065,10));
