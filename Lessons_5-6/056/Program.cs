// 56.	Написать программу копирования массива

int[] Fill_Array(int size = 10, int min = -100, int max = 100)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++) array[i] = new Random().Next(min, max);
    return array;
}

int Make_Tab_to_Print(int[] input_array)
{
    int num = input_array.Max(Math.Abs);
    int tab_space = 3;  // базовая величина отступа (в нее также закладывается знак "-" для отрицательных чисел)
    while (num / 10 > 0)
    {
        num /= 10;
        tab_space++;
    }
    return tab_space + 1;
}

void Print_Array(int[] array_to_print)
{
    int tab = Make_Tab_to_Print(array_to_print);
    foreach (int el in array_to_print) System.Console.Write("{0, " + tab + "}", el);
    System.Console.WriteLine();
}

int[] Make_Array_Copy(int[] input_array)
{
    int[] copied_array = new int[input_array.Length];
    for (int i = 0; i < copied_array.Length; i++) copied_array[i] = input_array[i];
    return copied_array;
}

int[] array_56 = Fill_Array();
Print_Array(array_56);

int[] array_56_copy = Make_Array_Copy(array_56);
Print_Array(array_56_copy);