// тип данных Char - Символ

char c = 'a';
c = '\x64';    // указание символа через его код в десятичной системе
c = '\u0064';  // указание символа через его код в десятичной системе
char b = 'a';

System.Console.WriteLine(c + b);  // вывод суммы кодов символов в шеснадцатиричной системе
System.Console.WriteLine(c.ToString() + b.ToString());  // склеивание символов в строку
System.Console.WriteLine((int)b);  // вывод кода символа в шестнадцатиричной системе

if (b >= '0' && b <= '9') System.Console.WriteLine("It's digit");
if (b >= 'A' && b <= 'Z') System.Console.WriteLine("It's big Latin");
if (b >= 'A' && b <= 'Z' || b >= 'a' && b <= 'z') System.Console.WriteLine("It's Latin");

if (Char.IsDigit(b)) System.Console.WriteLine("It's digit");
