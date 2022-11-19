// Алгоритм Евклида

System.Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

/*
#region Basic case

int MaxDivider(int arg1, int arg2)
{
    int max_div = arg1;
    while (arg1 != arg2)
    {
        if (arg1 > arg2) arg1 -= arg2; else arg2 -= arg1;
    }
    return arg1;
}

#endregion
*/

#region Quick case  // такой вариант алгоритма существенно сокращает количество производимых вычислений

int MaxDivider(int arg1, int arg2)
{
    int max_div = arg1;
    while (arg1 != 0 && arg2 != 0)
    {
        if (arg1 > arg2) arg1 %= arg2; else arg2 %= arg1;
    }
    return arg1 + arg2;
}

#endregion


System.Console.WriteLine($"Для чисел {num1} и {num2} максимальный общий дилитель равен: {MaxDivider(num1, num2)}");