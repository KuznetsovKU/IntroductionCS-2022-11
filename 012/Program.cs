// 12.	С клавиатуры вводится целое число из  диапазона  [10, 99]. Показать наибольшую цифру числа

System.Console.Write("Введите число от 10 до 99: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num / 10 > num % 10)
{
    System.Console.WriteLine($"Наибольшая цифра введенного числа: {num / 10}");
}
else
{
    System.Console.WriteLine($"Наибольшая цифра введенного числа: {num % 10}");
}