// 54.	С клавиатуры вводится число N. Показать первые N чисел Фибоначчи. Принять первые числа равными 0 и 1

System.Console.Write("Введите границу последовательности Фибоначчи: ");
int border = Convert.ToInt32(Console.ReadLine());

int Make_Tab_to_Print(double[] input_array)
{
    int num = Convert.ToInt32(input_array.Max(Math.Abs));
    int tab_space = 3;
    while (num / 10 > 0)
    {
        num /= 10;
        tab_space++;
    }
    return tab_space + 1;
}

void Print_Array(double[] array_to_print)
{
    double tab = Make_Tab_to_Print(array_to_print);
    foreach (int el in array_to_print) System.Console.Write("{0, " + tab + "}", el);
    System.Console.WriteLine();
}

double[] Fill_Fibonacci_Array(int size)  // Циклом без рекурсии
{
    double[] array = new double[size];
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < array.Length; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }
    return array;
}

double[] array_54 = Fill_Fibonacci_Array(border);
Print_Array(array_54);

double Find_Fibonacci_Value(int num)
{
    if (num == 1 || num == 2) return 1;
    else return Find_Fibonacci_Value(num - 1) + Find_Fibonacci_Value(num - 2);
}

double[] Fill_Fibonacci_Array_Rec(int size) // с использованием рекурсии
{
    double[] array = new double[size];
    array[0] = 0;
    for (int i = 1; i < array.Length; i++)
    {
        array[i] = Find_Fibonacci_Value(i);
    }
    return array;
}

double[] array_54_Rec = Fill_Fibonacci_Array_Rec(border);
Print_Array(array_54_Rec);
