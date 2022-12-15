// 95. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//     Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] FillRandom3DArray(int firstDimension, int secondDimention, int thirdDimention, int min = 0, int max = 10)
{
    int[,,] threedimensionalArray = new int[firstDimension, secondDimention, thirdDimention];
    for (int i = 0; i < firstDimension; i++)
    {
        for (int j = 0; j < secondDimention; j++)
        {
            for (int k = 0; k < thirdDimention; k++)
            {
                threedimensionalArray[i,j,k] = new Random().Next(min, max + 1);
            }
        }
    }
    return threedimensionalArray;
}

void Print3DArray(int[,,] arrayToPrint)
{
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            for (int k = 0; k < arrayToPrint.GetLength(2); k++)
            {
                System.Console.Write($"{arrayToPrint[i,j,k]}({i},{j},{k})  ");;
            }
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

int[,,] dataCube = FillRandom3DArray(3,3,3,10,99);
Print3DArray(dataCube);