// 6.	Написать программу вычисления значения функции y = sin(a). (Класс Math). 

System.Console.Write("Введите значение угла: ");
double angle = Convert.ToDouble(Console.ReadLine());
double sine_entered_angle = Math.Sin(angle);
System.Console.WriteLine($"Синус угла {angle} равен {sine_entered_angle}");