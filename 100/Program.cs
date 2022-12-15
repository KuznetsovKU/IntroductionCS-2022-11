// 100. Спирально заполнить двумерный массив:

void Print2DArray(int[,] arrayToPrint)
{
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            System.Console.Write($"{arrayToPrint[i, j]}\t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

int[,] FillSpiralMatrix(int rows, int columns)
{   int[,] matrix = new int[rows, columns];
    int currentRow = 0;        // задаем актуальную строку для присваивания значения
    int currentColumn = 0;     // задаем актуальный столбец для присваивания значения
    int columnDirection = 1;   // задаем направление перемещения по столбцам для присваивания значения
    int rowDirection = 0;      // задаем направление перемещения по строкам для присваивания значения
    int directionChanges = 0;  // задаем счетчик изменения направлений
    int endCell = columns;     // задаем конечную точку перед сменой направления (первая смена по достижении последнего индекса первой строки)

    for (int i = 0; i < (rows * columns); i++) // перебор по общему количеству значений в матрице
    {
        matrix[currentRow, currentColumn] = i + 1;
        endCell -=1;      // уменьшаем расстояние до конечной точки в текущем направлении
        if (endCell == 0) // если двигаться в текущем направлении больше некуда
        {
            // меняем значение конечной точки в соответствии с новым направлением
            endCell = columns * (directionChanges %2) + rows * ((directionChanges + 1) %2) - (directionChanges/2 - 1) - 2;
            // алгоритм смены направления 
            int temp = columnDirection;
            columnDirection = -rowDirection;
            rowDirection = temp;
            // увеличиваем счетчик смены направлений
            directionChanges++;
        }
        // переходим на новый индекс в соответствии с актуальным направлением
        currentColumn += columnDirection;
        currentRow += rowDirection;
    }
    return matrix;
}

int[,] spiralMatrix = FillSpiralMatrix(3, 3);
Print2DArray(spiralMatrix);