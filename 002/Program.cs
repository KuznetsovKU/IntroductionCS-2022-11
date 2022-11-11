// Вписать условие задачи
System.Console.WriteLine("Введите число num1:");
double num1 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите число num2:");
double num2 = Convert.ToDouble(Console.ReadLine());

if (num1*num1 == num2) 
{
    System.Console.WriteLine($"{num2} является квадратом {num1}");
}
if (num2*num2 == num1)
{
    System.Console.WriteLine($"{num1} является квадратом {num2}");
}