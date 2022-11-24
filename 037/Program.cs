// 37.	Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

int[] Fill_Array(int size, int min, int max)
{
    int[] filled_array = new int[size];
    for (int i = 0; i < filled_array.Length; i++)
    {
        filled_array[i] = new Random().Next(min, max);
    }
    return filled_array;
}

void PrintArray(int[] array_to_print)
{
    foreach (int value in array_to_print) System.Console.Write($"{value, 5}");
    System.Console.WriteLine();
}

int Count_Even_Num(int[] array)
{
    int count_even = 0;
    foreach (int value in array)
    {
        if (value % 2 == 0) count_even++;
    }
    return count_even;
}

int Count_Odd_Num(int[] array)
{
    int count_odd = 0;
    foreach (int value in array)
    {
        if (value % 2 != 0) count_odd++;
    }
    return count_odd;
}

int[] array_37 = Fill_Array(10, 100, 1000);
PrintArray(array_37);
System.Console.WriteLine($"Количество четных чисел в массиве: {Count_Even_Num(array_37)}");
System.Console.WriteLine($"Количество нечетных чисел в массиве: {Count_Odd_Num(array_37)}");

void Count_Even_Odd(int[] array)
{
    int count_even = 0, count_odd = 0;
    foreach (int value in array)
    {
        if (value % 2 == 0) count_even++; else count_odd++;
    }
    System.Console.WriteLine($"В заданном массиве количество четных чисел: {count_even}, а нечетных: {count_odd}");
}

Count_Even_Odd(array_37);
