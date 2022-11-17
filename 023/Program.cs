// 23.	Найти расстояние между точками в пространстве 2D

System.Console.WriteLine("Введите координаты начала x1, y1 ");
double x1 = Convert.ToDouble(Console.ReadLine());
double y1 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите координаты начала x2, y2 ");
double x2 = Convert.ToDouble(Console.ReadLine());
double y2 = Convert.ToDouble(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

System.Console.WriteLine($"Расстояние между введенными координатами: {distance}");