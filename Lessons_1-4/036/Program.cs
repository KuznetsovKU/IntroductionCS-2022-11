// 36.	Определить, присутствует ли в заданном массиве, некоторое число

int[] Fill_Array(int size = 10, int min = -100, int max = 100)
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
    foreach (int value in array_to_print)
    {
        System.Console.Write($"{value, 3}");
    }
}

void Find_Matches(int[] array, int searched_value)
{
    List<int> matches = new List<int>();
    int matches_counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == searched_value)
        {
            matches_counter++;
            matches.Add(i);
        }
    }
    System.Console.WriteLine($"Искомое значение в массиве встречается {matches_counter} раз на следующих позициях: ");
    foreach (int value in matches)
    {
        System.Console.Write($"{value, 3}");
    }
}


int[] array36 = Fill_Array(10, 3, 7);
System.Console.Write("Введите искомое значение: ");
int searched_value = Convert.ToInt32(Console.ReadLine());
PrintArray(array36);
System.Console.WriteLine();
Find_Matches(array36, searched_value);
