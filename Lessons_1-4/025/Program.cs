// 25.	Вывести на экран кубы чисел от 1 до N
System.Console.Write("Введите желаемую степень числа: ");
int grade = Convert.ToInt32(Console.ReadLine());

int num = new Random().Next(1, 10);

void Show_X_grade(int arg1, int arg2 = 3)  // arg1 = финальное число, arg2 = степень
{
    System.Console.WriteLine($"Число / Степень {arg2}");
    for (int i = 1; i <= arg1; i++)
    {
        System.Console.WriteLine($"{i, 2}{Convert.ToInt32(Math.Pow(i, arg2)) , 11}");
    }
}

Show_X_grade(num);         // вызов с значением степени по умолчанию (3-куб)
Show_X_grade(num, grade);  // вызов с передачей значения степени