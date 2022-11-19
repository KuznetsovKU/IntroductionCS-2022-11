// 27.	Возведите число А в натуральную степень B используя цикл

int num = new Random().Next(1, 10);
int grade = new Random().Next(1, 5);

int Count_Grade(int arg1, int arg2)  // arg1 = число, arg2 = степень
{
    int result = 1;
    for (int i = 1; i <= arg2; i++)
    {
        result *= arg1;
    }
    return result;
}

System.Console.WriteLine($"Число {num} в степени {grade} равно: {Count_Grade(num, grade)}");