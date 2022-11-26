// 30.	Написать программу вычисления произведения чисел от 1 до N

int num = new Random().Next(1, 10);

int Count_Factorial(int arg1)
{
    int result = 1;
    for (int i = 1; i <= arg1; i++) result *= i;
    return result;
}

System.Console.WriteLine($"Произведение чисел от 1 до {num} равно: {Count_Factorial(num)}");