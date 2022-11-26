// 41.	В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

double[] RandomIntArray(int size = 10)
{
    double[] newArray = new double[size];
    Random random = new System.Random();
    for (int i = 0; i < size; i++)
    {
        newArray[i] = Math.Round(random.NextDouble(), 2);
    }
    return newArray;
}

void PrintArray(double[] arg1)
{
    for (int i = 0; i < arg1.Length; i++)
    {
        System.Console.Write($"{arg1[i], 7}");
    }
}

double[] newArray = RandomIntArray(12);

double Max(double[] arr)
{
    double max = arr[0];
    foreach (double value in arr)
    {
        if (value > max) max = value;
    }
    return max;
}

double Min(double[] arr)
{
    double min = arr[0];
    foreach (double value in arr)
    {
        if (value < min) min = value;
    }
    return min;
}

PrintArray(newArray);
System.Console.WriteLine();
System.Console.WriteLine($"Максимальное значение в заданном массиве: {Max(newArray)}");
System.Console.WriteLine($"Минимальное значение в заданном массиве: {Min(newArray)}");
System.Console.WriteLine($"Разница Max-Min в заданном массиве: {Math.Round(Max(newArray) - Min(newArray), 3)}");