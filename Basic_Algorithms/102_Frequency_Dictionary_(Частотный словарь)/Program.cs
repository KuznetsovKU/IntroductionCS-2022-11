// Frequency_Dictionary_(Частотный словарь)

// 94.	Составить частотный словарь элементов одномерного массива состоящих из чисел от 0 до 99.

int[] FillRandomArray(int size, int min, int max)
{
    int[] outputArray = new int[size];
    for (int i = 0; i < size; i++) outputArray[i] = new Random().Next(min, max + 1);
    return outputArray;
}

void PrintArray(int[] arrayToPrint)
{
    foreach (int element in arrayToPrint) System.Console.Write($"{element}\t");
    System.Console.WriteLine();
}

int FindMaxInArray(int[] inputArray)
{
    int max = inputArray[0];
    foreach (int element in inputArray)
    {
        if (element > max) max = element;
    }
    return max;
}

void FrequencyArray(int[] inputArray)  // способ с использованием частотного массива менее эффективен с точки зрения нагрузки на память
{
    // создаем новый массив равный по длине максимальному элементу исходного массива, но заполненный нулями
    int[] frequencyArray = new int[FindMaxInArray(inputArray) + 1];  // поиск максимального элемента входящего массива через отдельный метод
    foreach (int element in inputArray)
    {
        // для каждого вхлждения Элемента в исследуемый массив увеличиваем значение элемента частотного массива (по соответствующему индексу) на 1
        // т.о. пересчитываем, сколько раз каждый элемент повторяется в исходном массиве
        // для ненайденных элементов значение соответствующего индекса частотного массива остается равным 0
        frequencyArray[element]++;
    }
    for (int i = 0; i < frequencyArray.Length; i++)
    {
        if (frequencyArray[i] != 0)  // исключаем из вывода элементы, не встречающиеся в исходном массиве (можно не исключать) 
        {
            System.Console.WriteLine($"Элемент со значением {i} встречается {frequencyArray[i]} раз");
        }
    }
}

void FrequencyDictionary(int[] inputArray)  // приоритетный способ, т.к. не строит нерациональных массивов
{
    SortedDictionary<int, int>  freqDict = new SortedDictionary<int, int>(); // <ключ, значение>. Без Sorted - будет сформирован не отсортированный словарь
    foreach (int element in inputArray)
    {
        if (freqDict.ContainsKey(element)) freqDict[element]++;
        else freqDict.Add(element, 1);
    }
    foreach (var el in freqDict) System.Console.WriteLine($"Элемент со значением {el.Key} встречается {el.Value} раз");
}

int[] data = FillRandomArray(20, 0, 9);
PrintArray(data);
//int[] data = { 1, 3, 4, 8, 3, 5, 8 };
FrequencyArray(data);
System.Console.WriteLine();
FrequencyDictionary(data);