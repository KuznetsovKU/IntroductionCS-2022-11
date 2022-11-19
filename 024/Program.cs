// 24.	Вывести на экран таблицу квадратов чисел от 1 до N

int num = new Random().Next(1, 10);

void Squares_Table(int arg1)
{
    System.Console.WriteLine("Число / Квадрат");
    for (int i = 1; i <= arg1; i++)
    {
        System.Console.WriteLine($"{i, 2}{i * i, 11}");
    }
}

Squares_Table(num);