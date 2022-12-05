// 70.	Показать натуральные числа от 1 до N, N задано

void ShowNumbers(int start = 1, int fin = 10)
{
    if (start <= fin)
    {
        System.Console.Write($"{start}\t");
        ShowNumbers(start + 1, fin);
    }
}

ShowNumbers();
