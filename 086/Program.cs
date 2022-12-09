// 86. Подсчитать сколько раз определенный символ (например 'a') встречается в строке.

int CountSimbolInclusion(string inputString, char requestedChar)
{
    int counter = 0;
    foreach (char c in inputString)
    {
        if (c == requestedChar) counter++;
    }
    return counter; 
}

System.Console.WriteLine(CountSimbolInclusion("Подсчитать сколько раз определенный символ (например 'a') встречается в строке.", 'a')); // англ a
System.Console.WriteLine(CountSimbolInclusion("Подсчитать сколько раз определенный символ (например 'a') встречается в строке.", 'а')); // рус a