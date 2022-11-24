// По заданному с клавиатуры номеру дня недели вывести его название

System.Console.Write("Введите порядковый номер дня недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

switch(dayNumber)  // Базовый вариант
{
    case 1:
        System.Console.WriteLine("Понедельник");
        break;
    case 2:
        System.Console.WriteLine("Вторник");
        break;
    case 3:
        System.Console.WriteLine("Среда");
        break;
    case 4:
        System.Console.WriteLine("Четверг");
        break;
    case 5:
        System.Console.WriteLine("Пятница");
        break;
    case 6:
        System.Console.WriteLine("Суббота");
        break;
    case 7:
        System.Console.WriteLine("Воскресенье");
        break;
    default:
        System.Console.WriteLine("Не правильный ввод");
        break;
}

switch(dayNumber)  // Вариант с вложениями и множественными условиями
{
    case > 0 and <= 5:
        System.Console.Write("Сегодня рабочий день. А, если точнее: ");
        switch(dayNumber)
        {
            case 1:
                System.Console.WriteLine("Понедельник");
                break;
            case 2:
                System.Console.WriteLine("Вторник");
                break;
            case 3:
                System.Console.WriteLine("Среда");
                break;
            case 4:
                System.Console.WriteLine("Четверг");
                break;
            case 5:
                System.Console.WriteLine("Пятница");
                break;
        }
        break;
    case > 5 and <= 7:
        System.Console.Write("Сегодня выходной. А, если точнее: ");
        switch(dayNumber)
        {
            case 6:
                System.Console.WriteLine("Суббота");
                break;
            case 7:
                System.Console.WriteLine("Воскресенье");
                break;
        }
        break;
    default:
        System.Console.WriteLine("Не правильный ввод");
        break;
}

