// 82. C клавиатуры вводится строка разделенная точкой. Подсчитать количество символов до точки

string text = "C клавиатуры вводится строка разделенная точкой. Подсчитать количество символов до точки";

int CountCharsToSimbol (string inputString, char simbol)
{
    int simbolIndex = inputString.IndexOf(simbol);
    string temp = inputString.Substring(0, simbolIndex);
    return temp.Length;
}

System.Console.WriteLine(CountCharsToSimbol(text, '.'));