// 55.	Написать программу масштабирования фигуры
//      переделать решение  через нахождение центра фигуры и отстройку новой фигуры относительно старого центра

System.Console.WriteLine("Введите координаты отрезка согласно примера: (0,0) (2,0) (2,2) (0,2)");
string? coordinates = Console.ReadLine();
System.Console.Write("Введите коэффициент масштабирования: ");
double scaling_factor = Convert.ToDouble(Console.ReadLine());

int Count_Apex(string input)
{
    int apexes_count = 0;
    foreach (char el in input) if (el == ',') apexes_count++;
    return apexes_count;
}

double[] Find_Coordinates(string input)
{
    double[] coordinates_array = new double[Count_Apex(input) * 2];
    for (int i = 0; i < coordinates_array.Length; i++)
    {
        for (int j = 0; j < input!.Length; j++)
        {
            string point = string.Empty;
            while (input[j] != ',' && input[j] != '(' && input[j] != ')' && input[j] != ' ')
            {
                if (j != input.Length - 1)
                {
                    point += input[j];
                    j++;
                }
                else
                {
                    point += input[j];
                    break;
                }
            }
            if (point != string.Empty)
            {
                coordinates_array[i] = Convert.ToDouble(point);
                i++;
            }
        }
    }
    return coordinates_array;
}

int Make_Tab_to_Print(double[] input_array)
{
    int num = Convert.ToInt32(input_array.Max(Math.Abs));
    int tab_space = 0;
    while (num / 10 > 0)
    {
        num /= 10;
        tab_space++;
    }
    return tab_space + 1;
}

void Print_Array(double[] array_to_print)
{
    int tab = Make_Tab_to_Print(array_to_print) + 3;
    foreach (int el in array_to_print) System.Console.Write("{0, "+tab+"}", el);
    System.Console.WriteLine();
}

double[] Scale_Coordinates(double[] input_coordinates, double zoom)
{
    double[] new_coordinates = new double[input_coordinates.Length];
    for (int i = 0; i < new_coordinates.Length; i++) new_coordinates[i] = input_coordinates[i] * zoom;
    return new_coordinates;
}

/*
#region Попытка преобразовать одномерный массив в двумерный (пока не удачная)

int[,] Fill_Coordinate_Matrix(string input)
{
    int[] coordinate_array = Find_Coordinates(input);
    int[,] coordinate_matrix = new int[Count_Apex(input), 2];
    for (int i = 0; i < coordinate_array.Length; i += 2) 
    {
        for (int j = 1; j < coordinate_array.Length; j +=2)
        {
            coordinate_matrix[i] = coordinate_array[i];
        }
    }
    //for (int row = 0; row < coordinate_matrix.GetLength(0); row++)
    //{
    //    for (int column = 0; column < coordinate_matrix.GetLength(1); column++)
    //    {
    //        for (int i = 0; i < coordinate_array.Length; i++) coordinate_matrix[row, column] = coordinate_matrix[coordinate_array[i], coordinate_array[i+1]];
    //    }
    //}
    return coordinate_matrix;
}

void Print_Matrix(int[,] input_matrix)
{
    for (int row = 0; row < input_matrix.GetLength(0); row++)
    {
        for (int column = 0; column < input_matrix.GetLength(1); column++)
        {
            System.Console.Write($"{input_matrix[row, column]} ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

#endregion
*/

void Print_Coordinates(double[] coordinates_array)
{
    for (int i = 0; i < coordinates_array.Length; i++)
    {
        if (i % 2 == 0) System.Console.Write($"({coordinates_array[i]},"); else System.Console.Write($"{coordinates_array[i]}) ");
    }
    System.Console.WriteLine();
}

double[] coord_arr = Find_Coordinates(coordinates);
double[] zoommed_coord = Scale_Coordinates(coord_arr, scaling_factor);

System.Console.WriteLine("Введенные координаты");
Print_Coordinates(coord_arr);
System.Console.WriteLine();

System.Console.WriteLine("Координаты после масштабирования");
Print_Coordinates(zoommed_coord);