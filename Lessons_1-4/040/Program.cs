// 40.	Задан массив a из N элементов. Заполнить массив случайными числами от 1 до 10. 
//      Создайте массив, который является произведением пар чисел в одномерном массиве a. 
//      Парой считаем первый и последний элемент, второй и предпоследний и т.д.

System.Console.Write("Введите количество элементов массива: ");


int[] Fill_Array(int size, int min = 1, int max = 10)
{
    int[] filled_array = new int[size];
    for (int i = 0; i < filled_array.Length; i++) filled_array[i] = new Random().Next(min, max);
    return filled_array;
}

void PrintArray(int[] array_to_print)
{
    foreach (int value in array_to_print) System.Console.Write($"{value, 5}");
    System.Console.WriteLine();
}


int[] New_Array(int[] input_array)
{
    int new_array_size;
    bool flag;
    if (input_array.Length % 2 == 0) 
    {
        new_array_size = input_array.Length / 2;
        flag = true;
    } 
        else 
        {
            new_array_size = input_array.Length / 2 + 1;
            flag = false;
        }

    int[] new_array = new int[new_array_size];

    switch (flag)
    {
        case true:
            for (int i = 0; i < new_array_size; i++)
            {
                new_array[i] = input_array[i] * input_array[input_array.Length - (1 + i)];
            }
            break;
        case false:
            for (int i = 0; i < new_array_size - 1; i++)
            {
                new_array[i] = input_array[i] * input_array[input_array.Length - (1 + i)];
            }
            new_array[new_array_size - 1] = input_array[input_array.Length / 2];
            break;
    }
    return new_array;
}

int array_40_size = Convert.ToInt32(Console.ReadLine());
int[] array_40 = Fill_Array(array_40_size);
PrintArray(array_40);
int[] newArray = New_Array(array_40);
PrintArray(newArray);
