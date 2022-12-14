// 33.	Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

int[] RandomIntArray(int size = 10, int min = 0, int max = 100)
{
    int[] newArray = new int[size];
    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        newArray[i] = random.Next(min, max);
    }
    return newArray;
}

void PrintArray(int[] arg1)
{
    for (int i = 0; i < arg1.Length; i++)
    {
        System.Console.Write($"{arg1[i], 5}");
    }
}


int[] array = RandomIntArray(8, 0, 2);  // max == 2, т.к. 2 не включается (ДО 2)

PrintArray(array);
