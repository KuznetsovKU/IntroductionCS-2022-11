// Вывести числа от 1 до N без использования цикла

/*
#region With GOTO

int i = 1;
int N = 10;
metka:
System.Console.WriteLine(i);
i++;
if (i < N) goto metka;

#endregion
*/

void Loop(int i, int N)
{
    if (i<=N)
    {
        System.Console.WriteLine(i);
        Loop(i+1, N);
    }
}

Loop(1, 10);

