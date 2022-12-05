// 53.	Найти точку пересечения двух прямых заданных уравнением 
//      y = k1 * x + b1, 
//      y = k2 * x + b2, 
//      b1 k1 и b2 и k2 заданы

int[] Fill_Coordinates()
{
    System.Console.Write("Введите координаты отрезка через запятую (x1,y1,x2,y2): ");
    string? coordinates = Console.ReadLine();
    if (coordinates!.Length < 7) coordinates = "0,0,1,1";  // попытка встроить "защиту от дурака"
    int[] line_cut = new int[4];
    for (int i = 0; i < line_cut.Length; i++)
    {
        for (int j = 0; j < coordinates!.Length; j++)
        {
            string point = string.Empty;
            while (coordinates[j] != ',')
            {
                if (j != coordinates.Length - 1)
                {
                    point += coordinates[j];
                    j++;
                }
                else
                {
                    point += coordinates[j];
                    break;
                }
            }
            line_cut[i] = Convert.ToInt32(point);
            i++;
        }
    }
    return line_cut;
}

int Make_Tab_to_Print(int[] input_array)
{
    int num = input_array.Max(Math.Abs);
    int tab_space = 0;
    while (num / 10 > 0)
    {
        num /= 10;
        tab_space++;
    }
    return tab_space + 1;
}

void Print_Array(int[] array_to_print)
{
    int tab = Make_Tab_to_Print(array_to_print) + 3;
    foreach (int el in array_to_print) System.Console.Write("{0, "+tab+"}", el);
    System.Console.WriteLine();
}

void Find_Cross_Point(int[] array_1, int[] array_2)
{
    int k1 = (array_1[3] - array_1[1]) / (array_1[2] - array_1[0]);
    int b1 = (array_1[2] * array_1[1] - array_1[0] * array_1[3]) / (array_1[2] - array_1[0]);
    int k2 = (array_2[3] - array_2[1]) / (array_2[2] - array_2[0]);
    int b2 = (array_2[2] * array_2[1] - array_2[0] * array_2[3]) / (array_2[2] - array_2[0]);
    if (b1 == b2) System.Console.WriteLine("Отрезки находятся на одной прямой, или отрезки не заданы");
    else if (k1 == k2) System.Console.WriteLine("Отрезки не пересекаются");
    else
    {
        int cp_x = (b2 - b1) / (k1 - k2);
        int cp_y = k1 * cp_x + b1;
        System.Console.WriteLine($"Отрезки пересекаются в точке x:{cp_x} y:{cp_y}");
    }
}

int[] line_1 = Fill_Coordinates();
int[] line_2 = Fill_Coordinates();

Print_Array(line_1);
Print_Array(line_2);
Find_Cross_Point(line_1, line_2);
