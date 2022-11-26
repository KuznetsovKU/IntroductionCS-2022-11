// 3.	С клавиатуры вводятся два числа a и b. Найти максимальное из них.

System.Console.Write("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());

int max;

if (a > b)
{
    max = a;
}
else
{
    max = b;
}

System.Console.WriteLine($"Максимальное число из введенных: {max}");