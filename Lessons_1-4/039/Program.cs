// 39.	Найти сумму чисел одномерного массива стоящих на нечетной позиции

int[] RandomIntArray(int size = 10, int min = 0, int max = 100)
{
    int[] newArray = new int[size];
    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        newArray[i] = random.Next(min, max);
    }
    return newArray;
}

void PrintArray(int[] arg1)
{
    for (int i = 0; i < arg1.Length; i++)
    {
        System.Console.Write($"{arg1[i], 5}");
    }
}

int[] newArray = RandomIntArray(12, -9, 10);

int SumOddPos(int[] array)
{
    int result = 0;
    for (int i = 1; i < array.Length; i += 2)
        result += array[i];
    return result;
}

PrintArray(newArray);
System.Console.WriteLine();
System.Console.WriteLine($"Сумма значений с нечетными индексами: {SumOddPos(newArray)}");