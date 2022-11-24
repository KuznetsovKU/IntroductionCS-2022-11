// 35.	Написать программу замены элементов массива на противоположные

int[] Fill_Array(int size, int start, int fin)
{
    int[] filled_array = new int[size];
    for (int i = 0; i < size; i++)
    {
        filled_array[i] = new Random().Next(start, fin);
    }
    return filled_array;
}

void PrintArray(int[] array_to_print)
{
    for (int i = 0; i < array_to_print.Length; i++)
    {
        System.Console.Write($"{array_to_print[i], 3}");
    }
}

int[] Mirroring_Array(int[] input_array)
{
    int[] mirrored_array = new int[input_array.Length];
    for (int i = 0; i < input_array.Length; i++)
    {
        mirrored_array[i] = input_array[i] * -1;
    }
    return mirrored_array;
}


int[] array35 = Fill_Array(5, -10, 10);
PrintArray(array35);
System.Console.WriteLine();
int[] mirrored_array35 = Mirroring_Array(array35);
PrintArray(mirrored_array35);