// 17.	Дано число обозначающее день недели. Выяснить является номер дня недели выходным

System.Console.Write("Введите номер дня недели: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num == 6 || num == 7) System.Console.WriteLine("Это выходной.");
else System.Console.WriteLine("Нет, это НЕ выходной");