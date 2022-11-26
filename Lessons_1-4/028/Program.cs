// 28.	Определить количество цифр в числе. Сделать подпрограмму.

System.Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int Digit_Count (int arg1)  // Подпрограмма подсчета количества цифр в некотором числе
{
    int digit_counter = 0;
    while (Math.Abs(arg1 / 10) > 0)  // При таком условии не нужна отдельная проверка на "0"
    {
        arg1 /= 10;
        digit_counter++;
    }
    return digit_counter + 1;  // При значении arg1 == 0 автоматически засчитается 1 цифра
}

System.Console.WriteLine($"Количество цифр в числе {num}: {Digit_Count(num)}");