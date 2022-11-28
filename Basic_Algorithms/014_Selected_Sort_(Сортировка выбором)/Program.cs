// Сортировка выбором

int[] Fill_Array(int size = 10, int min = -100, int max = 100)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++) array[i] = new Random().Next(min, max);
    return array;
}

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

void Swap(ref int num1, ref int num2)
{
    int temp = num1;
    num1 = num2;
    num2 = temp;
}

void Selected_Sort(int[] input_array, out int count)
{
    count = 0;
    for (int i = 0; i < input_array.Length; i++)
    {
        for (int j = i + 1; j < input_array.Length; j++)
        {
            if (input_array[j] < input_array[i]) 
            {
                Swap(ref input_array[j], ref input_array[i]);
                count++;
            }
        }
    }
}



int[] array_BA_013 = Fill_Array();
Print_Array(array_BA_013);
int count = 0;
Selected_Sort(array_BA_013, out count);
Print_Array(array_BA_013);
System.Console.WriteLine(count);

