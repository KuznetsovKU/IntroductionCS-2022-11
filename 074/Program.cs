// 74.	Найти сумму цифр числа

int SumDigits(int num)
{
    if (num == 0) return 0;
    else return SumDigits(System.Math.Abs(num) / 10) + System.Math.Abs(num) % 10;  // System.Math.Abs добавлено для корректной работы метода я отрицательными числами
}

System.Console.WriteLine(SumDigits(-347));
