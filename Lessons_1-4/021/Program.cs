// 21.	Задать номер четверти, показать диапазоны для возможных координат

System.Console.Write("Введите номер координатной четверти (от 1 до 4): ");
int quarter = Convert.ToInt32(Console.ReadLine());

if(quarter == 1) System.Console.WriteLine("Допустимые координаты: X > 0, Y > 0");
if(quarter == 2) System.Console.WriteLine("Допустимые координаты: X < 0, Y > 0");
if(quarter == 3) System.Console.WriteLine("Допустимые координаты: X < 0, Y < 0");
if(quarter == 4) System.Console.WriteLine("Допустимые координаты: X > 0, Y < 0");