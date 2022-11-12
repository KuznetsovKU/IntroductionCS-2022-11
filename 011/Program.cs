// 11.	Дано число больше 9. Вывести на экран  вторую цифру числа с конца

System.Console.Write("Введите число больше 9: ");
int num = Convert.ToInt32(Console.ReadLine());

int sec_last_dig = (num / 10 ) % 10;

System.Console.WriteLine($"В числе {num} вторая цифра с конца: {sec_last_dig}");