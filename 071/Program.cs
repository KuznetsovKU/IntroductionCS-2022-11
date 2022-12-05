// 71.	Показать натуральные числа от N до 1, N задано

void ShowNumbersReverse(int start = 10, int fin = 1)
{
    if (fin <= start)
    {
        System.Console.Write($"{start}\t");
        ShowNumbersReverse(start - 1, fin);
    }
}

ShowNumbersReverse();