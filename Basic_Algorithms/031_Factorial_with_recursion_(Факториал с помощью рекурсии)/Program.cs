// Нахождение фактриала с помощью рекурсии

int Factorial(int num)
{
    if (num == 0) return 1;
    else return Factorial(num - 1) * num;
}

System.Console.WriteLine(Factorial(5));