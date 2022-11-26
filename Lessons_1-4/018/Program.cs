// 18.	По двум заданным числам проверять является ли одно квадратом другого. Используйте подпрограмму.

System.Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

/*
#region with int

int is_square (int arg1, int arg2)
{
    int result = 0;
    if (arg1 * arg1 == arg2 || arg2 * arg2 == arg1)
    {
        result = 1;
    }
    return result;
}

if (is_square(num1, num2) == 1) System.Console.WriteLine("Одно из введенных чисел является квадратом другого");
else System.Console.WriteLine("Ни одно из введенных чисел не является квадратом другого");

#endregion
*/

/*
#region with bool

bool is_square (int arg1, int arg2)
{
    bool result = false;
    if (arg1 * arg1 == arg2 || arg2 * arg2 == arg1)
    {
        result = true;
    }
    return result;
}
if (is_square(num1, num2)) System.Console.WriteLine("Одно из введенных чисел является квадратом другого");
else System.Console.WriteLine("Ни одно из введенных чисел не является квадратом другого");

#endregion
*/


#region with string

string is_square (int arg1, int arg2)
{
    string result = "Ни одно из введенных чисел не является квадратом другого";
    if (arg1 * arg1 == arg2)
    {
        result = $"Число {arg2} является квадратом числа {arg1}";
    }
    else if (arg2 * arg2 == arg1)
    {
        result = $"Число {arg1} является квадратом числа {arg2}";
    }
    return result;
}
 System.Console.WriteLine(is_square(num1, num2));

 #endregion