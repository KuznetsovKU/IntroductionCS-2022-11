#region Hide this  
// Console.WriteLine("Hello, World!"); 
#endregion

// С клавиатуры вводится целое число. Вывести квадрат числа

int a;
Console.Write("Введите число ");
string? num = Console.ReadLine();
a=Convert.ToInt32(num);
int b=a*a;
System.Console.WriteLine(a+"^2="+b);
System.Console.WriteLine($"{a}^2={b}");


