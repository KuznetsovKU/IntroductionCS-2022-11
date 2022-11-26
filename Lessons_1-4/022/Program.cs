// 22.	Программа проверяет пятизначное число на палиндромом.

System.Console.Write("Введите пятизначное число: ");
string? num = Console.ReadLine();
string? num_reverse = "";
int index = 0;

while (index < num.Length)
{
    num_reverse += Convert.ToString(Convert.ToInt32(num) / Convert.ToInt32(Math.Pow(10, index)) % 10);
    index++;
}

if (num == num_reverse) System.Console.WriteLine($"Число {num} является палиндромом"); else System.Console.WriteLine($"Число {num} НЕ является палиндромом");