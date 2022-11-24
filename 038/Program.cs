// 38.	В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int[] Fill_Array(int size, int min = -100, int max = 100)
{
    int[] filled_array = new int[size];
    for (int i = 0; i < filled_array.Length; i++) filled_array[i] = new Random().Next(min, max);
    return filled_array;
}

void PrintArray(int[] array_to_print)
{
    foreach (int value in array_to_print) System.Console.Write($"{value, 5}");
    System.Console.WriteLine();
}

int Find_Matches(int[] array, int segment_start = 10, int segment_fin = 100)
{
    int matches_counter = 0;
    foreach (int value in array)
    {
        if (value >= segment_start && value <= segment_fin) matches_counter++;
    }
    return matches_counter;
}

int[] array_38 = Fill_Array(123);
PrintArray(array_38);
System.Console.WriteLine($"Количество элементов из запрошенного отрезка: {Find_Matches(array_38)}");
