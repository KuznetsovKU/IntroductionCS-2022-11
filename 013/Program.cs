// 13.	Удалить вторую цифру целого числа введенного с клавиатуры.

System.Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"Число с удаленной второй цифрой с конца: {num / 100 * 10 + num % 10}");

int num_twin = num;
int digit_counter = 1;

while (num_twin / 10 > 0)
{
    digit_counter += 1;
    num_twin /= 10;
}

int first_part = Convert.ToInt32(Convert.ToInt32(num / Math.Pow(10, (digit_counter - 1))) * Math.Pow(10, (digit_counter - 2)));
System.Console.WriteLine($"Число с удаленной второй цифрой с начала: {first_part + num % Math.Pow(10, digit_counter - 2)}");