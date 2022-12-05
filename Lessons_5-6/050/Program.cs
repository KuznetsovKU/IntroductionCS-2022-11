// 50.	Выяснить являются ли три числа сторонами треугольника

/*
#region Обычный вариант

bool Check_Triangle (int side1, int side2, int side3)
{
    if (side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1) return true; else return false;
}

#endregion
*/

#region Сокращенный вариант (правильнее)

bool Check_Triangle (int side1, int side2, int side3) // Альтернативный метод
{
    return side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1;
}

#endregion

int num1 = 4, num2 = 5, num3 = 8;

System.Console.WriteLine(Check_Triangle(num1, num2, num3));

if (Check_Triangle(num1, num2, num3)) System.Console.WriteLine("YES"); else System.Console.WriteLine("NO");