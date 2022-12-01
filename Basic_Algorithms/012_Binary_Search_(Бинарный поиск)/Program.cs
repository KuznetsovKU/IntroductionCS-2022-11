// Бинарный поиск

int Binary_Search(int[] input_array, int searched_value)  // алгоритм бинарного поиска
{
    int ls = 0;                       // left side - левая граница поиска
    int rs = input_array.Length - 1;  // right side - правая граница поиска
    int index = ls + (rs - ls) / 2;   // центральная позиция в границах поиска
    while (input_array[index] != searched_value && ls < rs)
    {
        if (searched_value > input_array[index]) ls = index + 1; else rs = index;  // постепенно сужаем границы поиска
        index = ls + (rs - ls) /2;    // не забываем менять центральную позицию в границах поиска на каждой итерации
    }
    if (input_array[index] != searched_value) 
        return -1;
    else 
        return index;
}

int[] Fill_Array(int size = 10, int min = 0, int max = 200)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++) array[i] = new Random().Next(min, max);
    return array;
}

int Make_Tab_to_Print(int[] input_array)
{
    int num = input_array.Max(Math.Abs);
    int tab_space = 0;
    while (num / 10 > 0)
    {
        num /= 10;
        tab_space++;
    }
    return tab_space + 1;
}

void Print_Array(int[] array_to_print)
{
    int tab = Make_Tab_to_Print(array_to_print) + 3;
    foreach (int el in array_to_print) System.Console.Write("{0, "+tab+"}", el);
    System.Console.WriteLine();
}



int[] array_BA_012 = Fill_Array();
Print_Array(array_BA_012);
array_BA_012[4] = 3;
Array.Sort(array_BA_012);
Print_Array(array_BA_012);
int search_val = -2;
System.Console.WriteLine(Binary_Search(array_BA_012, search_val));

/*
int[] test_arr = {1, 3, 5, 7, 9, 11, 13, 15, 17, 19};
Print_Array(test_arr);
System.Console.WriteLine(Binary_Search(test_arr, 19));
*/