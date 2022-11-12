// 7.	Выяснить является ли число чётным.

System.Console.Write("Введите число num: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
{
    System.Console.WriteLine("Введенное число является четным");
}
else
{
    System.Console.WriteLine("Введенное число НЕ является четным");
}