// 19.	Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y  - эквивалентно - !(X || Y)==!X && !Y

System.Console.WriteLine("X Y ¬(X || Y) = ¬X && ¬Y");
System.Console.WriteLine("X Y !(X || Y)== !X && !Y");

System.Console.WriteLine($"0 0 {Convert.ToInt32(!(false || false)), 6} {Convert.ToInt32(!false && !false), 8}");
System.Console.WriteLine($"0 1 {Convert.ToInt32(!(false || true)), 6} {Convert.ToInt32(!false && !true), 8}");
System.Console.WriteLine($"1 0 {Convert.ToInt32(!(true || false)), 6} {Convert.ToInt32(!true && !false), 8}");
System.Console.WriteLine($"1 1 {Convert.ToInt32(!(true || true)), 6} {Convert.ToInt32(!true && !true), 8}");

/*
#region Пока что-то не получается

int x, y;
bool flag_X, flag_Y;

for (x = 0; x = 2; x++)
{
    if (x == 0) flag_X = false; else flag_X = true;
    if (x > 1) break;
    for (y = 0; y = 2; y++)
    {
        if (y == 0) flag_Y = false; else flag_Y = true;
        if (y > 1) break;
        if (!(flag_X || flag_Y) == (!flag_X && !flag_Y))
        {
            System.Console.WriteLine($"Если x = {x}, а y = {y}, выражение !(X || Y) == !X && !Y является истинным");
        }
        else System.Console.WriteLine($"Если x = {x}, а y = {y}, выражение !(X || Y) == !X && !Y НЕ является истинным");
    }
}

#endregion
*/
