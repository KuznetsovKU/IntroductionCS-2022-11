// 76.	Написать программу возведения числа А в целую степень B

double Power(int num, int grade)
{
    if (grade == 0) return 1;
    else if (grade > 0) return Power(num, grade - 1) * num;
    else return Power(num, grade + 1) / num;
}

System.Console.WriteLine(Power(2, -1));