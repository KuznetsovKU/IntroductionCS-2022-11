// 88. Заменить все вхождения подстроки w в строке st на строку v 
//     Вывести на экран первоначальную строку и конечную строку

string ChangeSubStrings (string inputString, string oldValue, string newValue)
{
    string outputString = inputString.Replace(oldValue, newValue);
    return outputString;
}

string text = "wild wild west";
System.Console.WriteLine(text);
System.Console.WriteLine(ChangeSubStrings(text, "w", "v"));