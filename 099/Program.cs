// 99. Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника

int[,] FillPascalTriangle(int size = 5)
{
    int[,] pascalTriangle = new int[size, size];
    for (int i = 0; i < size; i++)
    {
        pascalTriangle[i, 0] = 1;
        pascalTriangle[i, i] = 1;
    }
    for (int i = 2; i < size; i++) // начальное i = 2 т.к. во второй строке треугольника всего 2 элемента и мы их уже заполнили предыдущим циклом
    {
        for (int j = 1; j <= i; j++)  // начальное j = 1 т.к. первый j мы уже заполнили предыдущим циклом
        {
            pascalTriangle[i, j] = pascalTriangle[i - 1, j - 1] + pascalTriangle[i - 1, j];
        }
    }
    return pascalTriangle;
}

int Make_Tab_to_Print(int[,] input_array)
{
    int max = input_array[0, 0];
    for (int i = 0; i < input_array.GetLength(0); i++)
    {
        for (int j = 0; j < input_array.GetLength(1); j++)
        {
            if (input_array[i,j] > max) max = input_array[i,j];
        }
    }
    int tabSpace = 0;
    while (max / 10 > 0)
    {
        max /= 10;
        tabSpace++;
    }
    return tabSpace;
}

void PrintPascalTriangle(int[,] triangle)
{
    int space = Make_Tab_to_Print(triangle);
    int size = triangle.GetLength(0);
    int positionX = space * size;
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j <= i; j++)
        {
            Console.SetCursorPosition(positionX, i + 1);
            if (triangle[i, j] != 0) System.Console.Write("{0, "+space+"}", triangle[i, j]);
            positionX += space * 2;
        }
        positionX = space * size - space * (i + 1);
        System.Console.WriteLine();
    }
}

int[,] triangle_99 = FillPascalTriangle(11);
PrintPascalTriangle(triangle_99);
