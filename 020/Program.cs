// 20.	Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

System.Console.Write("Введите координату X: ");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координату Y: ");
int y = Convert.ToInt32(Console.ReadLine());

/*
#region first case

if(x > 0 && y > 0) System.Console.WriteLine("Координата находится в I четверти");
if(x < 0 && y > 0) System.Console.WriteLine("Координата находится в II четверти");
if(x < 0 && y < 0) System.Console.WriteLine("Координата находится в III четверти");
if(x > 0 && y < 0) System.Console.WriteLine("Координата находится в IV четверти");

#endregion
*/

/*
#region second case

if (x < 0)
{
    if (y > 0) System.Console.WriteLine("Координата находится в II четверти"); else System.Console.WriteLine("Координата находится в III четверти");
}
else
{
    if (y > 0) System.Console.WriteLine("Координата находится в I четверти"); else System.Console.WriteLine("Координата находится в IV четверти");
}

#endregion
*/

#region With method

int Find_Quarter (int arg1, int arg2)
{
    int quarter = 0;
    if (arg1 > 0 && arg2 > 0) quarter = 1;
    if (arg1 < 0 && arg2 > 0) quarter = 2;
    if (arg1 < 0 && arg2 < 0) quarter = 3;
    if (arg1 > 0 && arg2 < 0) quarter = 4;
    return quarter;
}

System.Console.WriteLine($"Введенные координаты находятся в {Find_Quarter(x, y)}-й четверти");

#endregion