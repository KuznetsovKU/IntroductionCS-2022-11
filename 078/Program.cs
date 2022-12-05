// 78.	В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». 
//      Покажите все слова (слова не обязательно осмысленные), состоящие из n букв, которые можно построить из букв этого алфавита


void ShowChars(string[] alphabet, int i = 0)
{
    if (i < alphabet.Length) 
    {
        System.Console.Write($"{alphabet[i]}\t");
        ShowChars(alphabet, i + 1);
    }
}

void MakeWords(int charCount, int i = 1)
{
    if (i < charCount)
    {
        ShowChars;
    }
}

string[] simbols = {"а", "и", "с", "в"};
ShowChars(simbols);