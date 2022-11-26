// 5.	С клавиатуры вводятся три числа. Найти максимальное из трех чисел

System.Console.Write("Введите число num1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число num2: ");
int num2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число num3: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if (num2 > max)
{
    max = num2;
}
if (num3 > max)
{
    max = num3;
}

System.Console.WriteLine($"Максимальное из введенных чисел: {max}");