// 51.	С клавиатуры вводится число N. Затем вводятся N чисел. Определить сколько чисел больше 0 введено с клавиатуры

System.Console.Write("Введите число: ");
int amount = Convert.ToInt32(Console.ReadLine());

#region Ручное заполнение массива

int[] Fill_Array(int size)
{
    int[] array = new int [size];
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"Введите {i + 1}-й элемент массива: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
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

int Count_Over_Num(int[] input_array, int compared_value = 0)
{
    int count = 0;
    foreach (int el in input_array)
    {
        if (el > compared_value) count++;
    }
    return count;
}

int[] array_051 = Fill_Array(amount);
Print_Array(array_051);
int val_to_compare = 0;
System.Console.WriteLine($"В заданном массиве количество элементов больше {val_to_compare}: {Count_Over_Num(array_051, val_to_compare)}");

#endregion

/*
#region Простой вариант

int count_over_0 = 0;

for (int i = 0; i < amount; i++)
{
    System.Console.Write($"Введите {i + 1}-е число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num > 0) count_over_0++;
}

System.Console.WriteLine($"Среди введенных чисел {count_over_0} больше 0");

#endregion
*/
