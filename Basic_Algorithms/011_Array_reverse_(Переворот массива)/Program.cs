// Переворот массива

int[] Fill_Array(int size = 10, int min = -100, int max = 100)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++) array[i] = new Random().Next(min, max);
    return array;
}

/*
#region case_1 - определение значения табуляции для метода Print_Array

int Find_Abs_Max_in_Array(int[] array)  // находим максимальное значение (по модулю) в массиве для определения количества цифр
{
    int max = array[0];
    foreach (int el in array)
    {
        if (Math.Abs(el) > Math.Abs(max)) max = el;
    }
    return max;
}

int Count_didits(int num)  // определяем количество цифр в максимальном числе массива
{
    int count = 0;
    while (Math.Abs(num) / 10 > 0)
    {
        num /= 10;
        count++;
    }
    return count + 1;
}

void Print_Array(int[] array_to_print)  // вывод с автоматически генерируемой табуляцией
{
    int tab = Count_didits(Find_Abs_Max_in_Array(array_to_print)) + 3;  // табуляция устанавливается автоматически в зависимости от количества цифр в максимальном числе массива
    string tab_str = "{0, "+tab+"}";
    foreach (int el in array_to_print) System.Console.Write(tab_str, el);
    System.Console.WriteLine();
}

#endregion
*/


#region case_2 - определение значения табуляции для метода Print_Array

int Make_Tab_to_Print(int[] array)  // 
{
    int num = array.Max(Math.Abs);
    int tab_space = 0;
    while (num / 10 > 0)
    {
        num /= 10;
        tab_space++;
    }
    return tab_space + 1;
}
    
void Print_Array(int[] array_to_print)  // вывод с автоматически генерируемой табуляцией
{
    int tab = Make_Tab_to_Print(array_to_print) + 3;  // табуляция устанавливается автоматически в зависимости от количества цифр в максимальном числе массива
    string tab_str = "{0, "+tab+"}";
    foreach (int el in array_to_print) System.Console.Write(tab_str, el);
    System.Console.WriteLine();
}

#endregion


void Swap(ref int num1, ref int num2)
{
    int temp = num1;
    num1 = num2;
    num2 = temp;
}

void Reverse_Array(int[] input_array)
{
    for (int i = 0; i < input_array.Length / 2; i++)  // если Length не разделить на 2 метод сработает, но перевернет массив ДВАЖДЫ
    {
        Swap(ref input_array[i], ref input_array[input_array.Length - 1 - i]);
    }
}

int[] array_BA_011 = Fill_Array();
Print_Array(array_BA_011);
Reverse_Array(array_BA_011);
Print_Array(array_BA_011);

int[] array_BA_011_2 = array_BA_011.Reverse().ToArray();  // встроенный алгоритм разворота массива через замену старого созданием нового
Print_Array(array_BA_011_2);