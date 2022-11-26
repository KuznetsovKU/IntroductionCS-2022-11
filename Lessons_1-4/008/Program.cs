// 8.	Вывести на экран числа от -N до N

System.Console.Write("Введите число num: ");
int num = Convert.ToInt32(Console.ReadLine());

int i = -num;

while (i <= num)
{
    System.Console.Write($"{i} ");
    i++;
}

System.Console.WriteLine();

for (int j = -num; j <= num; j++)
{
    System.Console.Write($"{j} ");
}