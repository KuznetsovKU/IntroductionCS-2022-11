// 72.	Показать натуральные числа от M до N, N и M заданы

void ShowNumbers(int start, int fin)
{
    if (start == fin) System.Console.WriteLine($"{start}\t");
    else if (start < fin) 
    {
        System.Console.Write($"{start}\t");
        ShowNumbers(start +1 , fin);
    }
    else if (start > fin)
    {
        System.Console.Write($"{start}\t");
        ShowNumbers(start - 1, fin);
    }
}

ShowNumbers(10, -1);
