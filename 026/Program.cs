// 26.	Найти сумму чисел от 1 до А

int num = new Random().Next(1, 10);

int Count_Summ_To_Num(int arg1)
{
    int result = 0;
    for (int i = 0; i <= arg1; i++)
    {
        result += i;
    }
    return result;
}

System.Console.WriteLine($"Сумма чисел от 1 до {num} равна: {Count_Summ_To_Num(num)}");