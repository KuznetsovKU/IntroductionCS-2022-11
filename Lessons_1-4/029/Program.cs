// 29.	Подсчитать сумму цифр в числе

int num = new Random().Next(1, 999_999);

int Count_Digits_Summ(int arg1)
{
    int result = 0;
    while (Math.Abs(arg1) > 0)
    {
        result += arg1 % 10;
        arg1 /= 10;
    }
    return result;
}

System.Console.WriteLine($"Сумма цифр в числе {num} равна: {Count_Digits_Summ(num)}");