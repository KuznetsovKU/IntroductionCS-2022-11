// 73.	Найти сумму элементов от M до N, N и M заданы

int CountSumm (int start, int fin)
{
    if (start == fin) return start;
    else if (start < fin) return CountSumm(start + 1, fin) + start;
    else return CountSumm(start - 1, fin) + start;
}

System.Console.WriteLine(CountSumm(1, 5));
