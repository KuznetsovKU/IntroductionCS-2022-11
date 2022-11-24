// Линейный поиск в массиве

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

int LinearSearch(int[] array, int request_value)
{
    int i = 0;
    while (i < array.Length && array[i] != request_value) i++;
    if (i == array.Length) return -1;
    else return i;
}

int[] array = RandomIntArray();
int request = 20;
array[4] = request;

PrintArray(array);
System.Console.WriteLine();
int lin_search_res = LinearSearch(array, request);
if (lin_search_res == -1)
    System.Console.WriteLine($"Element {request} not founded");
else
    System.Console.WriteLine($"Element {request} found at {lin_search_res}");