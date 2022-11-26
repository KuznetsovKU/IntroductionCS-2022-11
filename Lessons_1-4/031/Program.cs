// 31.	Сгенерировать 10 случайных чисел и показать кубы тех чисел, которые заканчиваются на четную цифру

System.Console.Write("Введите количество рассматриваемых чисел: ");
int amounth = Convert.ToInt32(Console.ReadLine());                 // Задаем количество рандомных чисел
System.Console.Write("Кратность какому числу проверяем?: ");
int divider = Convert.ToInt32(Console.ReadLine());                 // Задаем проверку кратности
System.Console.Write("Какую степень показать?: ");
int grade = Convert.ToInt32(Console.ReadLine());                   // Задаем искомую степень
Random random = new Random();



bool Test(int num_x)  // Выносим логику определения подходящего значения переменной num (тут num_x) в отдельный блок. Может пригодиться при дальнейшем тестировании программы
{
    if (num_x % divider == 0) return true; else return false;
    // return num_x % divider == 0;   - альтернативный вариант (более короткий и правильный) для проверок в строке выше
}

/*
#region Without Method

for (int i = 0; i < amounth; i++)
{
    int num = random.Next(1, 100);
    if (Test(num))
    {
        System.Console.WriteLine($"для числа {num} третья степень равна {(int) Math.Pow(num, grade)}");
    }
}
#endregion
*/



#region With Method

void Show_X_grade_for_several (int arg1)  // показать кубы тех ЧИСЕЛ, которые заканчиваются на четную цифру
{
    for (int i = 0; i < arg1; i++)
    {
        int num = random.Next(1, 100);
        System.Console.WriteLine(num);
        if (Test(num))
        {
            System.Console.WriteLine($"для числа {num} третья степень равна {(int) Math.Pow(num, grade)}");
        }
    }
}

Show_X_grade_for_several(amounth);

#endregion

