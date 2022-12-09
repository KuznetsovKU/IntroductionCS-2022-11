// 80. Вывести на экран кодировку символов по ASCII(с 32 до 122)

void ShowASCII(int start, int fin)
{
    if (start <= fin)
        for (int i = start; i <= fin; i++)
        {
            System.Console.Write($"{(char)i,2}");
        }
    else
    {
        for (int i = fin; i <= start; i++)
        {
            System.Console.Write($"{(char)i,2}");
        }        
    }
    System.Console.WriteLine();
}

ShowASCII(122, 32);

void ShowASCII_Rec(int start, int fin)  // с использованием рекурсии
{
    if(start == fin) System.Console.WriteLine($"{(char)start,2}");
    else if (start < fin)
    {
        System.Console.Write($"{(char)start,2}");
        ShowASCII_Rec(start + 1, fin);
    }
    else if (start > fin)
    {
        System.Console.Write($"{(char)start,2}");
        ShowASCII_Rec(start - 1, fin);
    }
}

ShowASCII_Rec(122, 32);