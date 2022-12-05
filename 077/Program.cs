// 77.	Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. 
//      Первые два элемента последовательности 0 и 1

int FindFibonacciNum(int num)
{
    if (num == 1) return 0;
    else if (num == 2) return 1;
    else return FindFibonacciNum(num - 1) + FindFibonacciNum(num - 2);
}

void ShowFibonacciLine(int num, int i = 1)
{
    if (i <= num)
    {
        System.Console.Write($"{FindFibonacciNum(i)}\t");
        ShowFibonacciLine(num, i + 1);
    }
}

int fiboNum = 8;
System.Console.WriteLine(FindFibonacciNum(fiboNum));
ShowFibonacciLine(fiboNum);