// 75.	Написать программу вычисления функции Аккермана

int AkkermanFunc(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return AkkermanFunc(m - 1, 1);
    else return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));
}

System.Console.WriteLine(AkkermanFunc(3, 3));