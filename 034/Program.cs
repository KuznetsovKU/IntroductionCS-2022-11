// 34.	Задать массив из 12 элементов, заполненных числами из [-9, 9]. Найти сумму положительных/отрицательных элементов массива

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

int SumPositive(int[] array)
{
    int result = 0;
    foreach (int value in array)
        if (value > 0) result += value;
    return result;
}

int SumNegative(int[] array)
{
    int result = 0;
    foreach (int value in array)
        if (value < 0) result += value;
    return result;
}

PrintArray(newArray);
System.Console.WriteLine();
System.Console.WriteLine($"Сумма положительных: {SumPositive(newArray)}");
System.Console.WriteLine($"Сумма отрицательных: {SumNegative(newArray)}");