// 10.	Вывести на экран последнюю цифру целого числа введенного с клавиатуры. 

System.Console.Write("Введите ваше число: ");
int num = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"Последняя цифра: {num % 10}");