// 89. Подсчитать сумму цифр, встречающихся в строке

int SummDigitsInText(string inputString)
{
    int counter = 0;
    foreach (char c in inputString)
    {
        if (char.IsDigit(c)) counter += Convert.ToInt32(c.ToString());
    }
    return counter;
}

System.Console.WriteLine(SummDigitsInText("kkjhv2312"));
