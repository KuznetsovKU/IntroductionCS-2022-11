// 9.	Вывести на экран четные числа от 1 до N

System.Console.Write("Введите число num: ");
int num = Convert.ToInt32(Console.ReadLine());

int i = 2;

while (i <= num)
{
    System.Console.Write($"{i} ");
    i += 2;
}

System.Console.WriteLine();

for (int j = 2; j <= num; j += 2)
{
    System.Console.Write($"{j} ");
}