// 81. Вывести на экран символы от A до Z как показано ниже: 
//     A 
//     BB 
//     CCC 

void ShowAlphabetTriangle(char start, char fin)
{
    for (int i = start; i <= fin; i++) System.Console.WriteLine(new String((char)i, (i - (int)start + 1)));
}

ShowAlphabetTriangle('A', 'Z');
