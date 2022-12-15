// 94.	Составить частотный словарь элементов двумерного массива состоящих из чисел от 0 до 99.

int[,] FillRandom2DArray(int rows, int columns, int min = 0, int max = 10)
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

void FrequencyDictionary(int[,] inputArray)  // приоритетный способ, т.к. не строит нерациональных массивов
{
    double elementAmount = Convert.ToDouble(inputArray.GetLength(0) * inputArray.GetLength(1));
    SortedDictionary<int, int> freqDict = new SortedDictionary<int, int>(); // <ключ, значение>. Без Sorted - будет сформирован не отсортированный словарь
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            if (freqDict.ContainsKey(inputArray[i,j])) freqDict[inputArray[i,j]]++;
            else freqDict.Add(inputArray[i,j], 1);
        }
    }
    foreach (var el in freqDict) 
    {
        System.Console.WriteLine($"Элемент со значением {el.Key} встречается {el.Value} раз. Частота: {el.Value / elementAmount}");
    }
}

int[,] matrix_94 = FillRandom2DArray(5,5);
Print2DArray(matrix_94);
FrequencyDictionary(matrix_94);