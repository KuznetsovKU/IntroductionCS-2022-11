// 15.	С клавиатуры вводится целое число. Вывести третью цифру числа или сообщить, что её нет (Вывести: NO).

System.Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num / 100 == 0)
{
    System.Console.WriteLine("NO");
}
else
{
    System.Console.WriteLine($"Третья с конца цифра введенного числа: {(num / 100) % 10}");

    int num_twin = num;
    int digit_counter = 1;

    while (num_twin / 10 > 0)
    {
        digit_counter++;
        num_twin /= 10;
    }

    int first_part = Convert.ToInt32(num / Math.Pow(10, (digit_counter - 3)));
    System.Console.WriteLine($"Третья с начала цифра введенного числа: {first_part % 10}");
}