// Пузырьковая сортировка

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

/*
#region Классический вариант (самый простой, но самый долгий)

void Bubble_Sort(int[] input_array)
{
    for (int i = 0; i < input_array.Length; i++)
    {
        for (int j = 0; j < input_array.Length - 1; j++)
        {
            if (input_array[j] > input_array[j + 1]) Swap (ref input_array[j], ref input_array[j + 1]);
        }
    }
}

#endregion
*/

/*
#region Вариант со счетчиком операций и фланом срабатывания Swap

void Bubble_Sort(int[] input_array, out int count)  // count - счетчик количества операций
{
    count = 0;
    for (int i = 0; i < input_array.Length; i++)
    {
        int flag = 0;          // переменная для отсечения лишних операций
        for (int j = 0; j < input_array.Length - 1 - i; j++)  // "-i" позволяет сократить количество операций в 2 раза
        {
            if (input_array[j] > input_array[j + 1]) 
            {
                Swap (ref input_array[j], ref input_array[j + 1]);
                flag = 1;      // если Swap сработал, меняем значение
            }
            count++;
        }
        if (flag == 0) break;  // если Swap не сработал, прекращаем работу метода, т.к. все уже отсортировано
    }
}

#endregion
*/

#region Вариант быстрее, но без излишеств

void Bubble_Sort(int[] input_array)
{
    for (int i = 0; i < input_array.Length; i++)
    {
        for (int j = 0; j < input_array.Length - 1 - i; j++)  // "-i" позволяет сократить количество операций в 2 раза
        {
            if (input_array[j] > input_array[j + 1]) Swap (ref input_array[j], ref input_array[j + 1]);
        }
    }
}

#endregion


int[] array_BA_013 = Fill_Array(100, 0, 999);
Print_Array(array_BA_013);
//int count = 0;
Bubble_Sort(array_BA_013);
Print_Array(array_BA_013);
//System.Console.WriteLine(count);
