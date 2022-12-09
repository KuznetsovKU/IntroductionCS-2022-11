// 87. Удалить среднюю букву при нечетной длине строки и две средние буквы при четной длине строки

string DelMiddleSimbols(string inputString)
{
    string outputString = string.Empty;
    if (inputString.Length % 2 == 0) outputString = inputString.Remove(inputString.Length / 2 - 1, 2);
    else outputString = inputString.Remove(inputString.Length / 2, 1);
    return outputString;
}

System.Console.WriteLine(DelMiddleSimbols("asdf"));