// 16.	Дано число. Проверить кратно ли оно 7 и 23

System.Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 23 == 0 && num % 7 == 0)
{
    System.Console.WriteLine($"{num} кратно 7 и 23");
}

else System.Console.WriteLine("NO");