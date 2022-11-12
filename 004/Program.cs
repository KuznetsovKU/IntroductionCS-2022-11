// 4.	По заданному с клавиатуры номеру дня недели вывести его название

System.Console.Write("Введите порядковый номер дня недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

#region Main code
//
if (dayNumber == 1)
{
    System.Console.WriteLine($"{dayNumber}-й день недели - это Понедельник");
}
else if (dayNumber == 2)
{
    System.Console.WriteLine($"{dayNumber}-й день недели - это Вторник");
}
else if (dayNumber == 3)
{
    System.Console.WriteLine($"{dayNumber}-й день недели - это Среда");
}
else if (dayNumber == 4)
{
    System.Console.WriteLine($"{dayNumber}-й день недели - это Четверг");
}
else if (dayNumber == 5)
{
    System.Console.WriteLine($"{dayNumber}-й день недели - это Пятница");
}
else if (dayNumber == 6)
{
    System.Console.WriteLine($"{dayNumber}-й день недели - это Суббота");
}
else if (dayNumber == 7)
{
    System.Console.WriteLine($"{dayNumber}-й день недели - это Воскресенье");
}
else
{
    System.Console.WriteLine($"{dayNumber}-й день недели??? Серьезно??? Пожалуйста, перепроверьте введенную информацию.");
}
//
#endregion


#region Second try
/*
if (dayNumber == 6 | dayNumber == 7)
{
    System.Console.Write($"{dayNumber}-й день недели - это выходной. А, если точнее, ");
    if (dayNumber == 6)
    {
        System.Console.WriteLine("Суббота");
    }
    else
    {
        System.Console.WriteLine("Воскресенье");
    }
}
else if (dayNumber == 1 | dayNumber == 2 | dayNumber == 3 | dayNumber == 4 | dayNumber == 5)
{
    System.Console.Write($"{dayNumber}-й день недели - рабочий день. А, если точнее, ");
    if (dayNumber == 1)
    {
        System.Console.WriteLine("Понедельник");
    }
    else if (dayNumber == 2)
    {
        System.Console.WriteLine("Вторник");
    }
    else if (dayNumber == 3)
    {
        System.Console.WriteLine("Среда");
    }
    else if (dayNumber == 4)
    {
        System.Console.WriteLine("Четверг");
    }
    else
    {
        System.Console.WriteLine("Пятница");
    }
}
else
{
    System.Console.WriteLine($"{dayNumber}-й день недели??? Серьезно??? Пожалуйста, перепроверьте введенную информацию.");
}
*/
#endregion