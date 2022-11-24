// Расчитать среднюю температуру за неделю

/*
#region Примитивный вариант

int t1, t2, t3, t4, t5, t6, t7;
int sum = 0;
t1 = Convert.ToInt32(Console.ReadLine());
t2 = Convert.ToInt32(Console.ReadLine());
t3 = Convert.ToInt32(Console.ReadLine());
t4 = Convert.ToInt32(Console.ReadLine());
t5 = Convert.ToInt32(Console.ReadLine());
t6 = Convert.ToInt32(Console.ReadLine());
t7 = Convert.ToInt32(Console.ReadLine());
sum = t1 + t2 + t3 + t4 + t5 + t6 + t7;
double average = sum / 7;
System.Console.WriteLine($"Средняя температура за неделю: {average}");

#endregion
*/

#region Вариант с Массивами

// Массивы - это ОБЪЕКТЫ !
int[] temperature;                 // значение массиву не присвоено (null)
int arr_size = 7;                  // задаем размер массива
temperature = new int [arr_size];  // создаем массив, т.е. в переменную temperature помещаем адрес массива, состоящего из 7 элементов
int sum2 = 0;
for (int i = 0; i < temperature.Length; i++)  // длинну заданного массива можно отражать через свойство .Length
{
    System.Console.Write($"Введите температуру за {i + 1}-й день: ");
    temperature[i] = Convert.ToInt32(Console.ReadLine());  // заполняем массив значениями
    sum2 += temperature[i];                                // обрабатываем значения массива
}

System.Console.WriteLine($"Средняя температура за неделю: {sum2 / temperature.Length}");
    
#endregion