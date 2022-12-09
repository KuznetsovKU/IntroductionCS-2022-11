// 84. Определить являются ли введенные с клавиатуры символы правильно записью целого числа. Вычислить сумму цифр введенного числа

void SummDigitsInText(string inputString)
{
    int counter = 0;
    bool onlyDigits = true;
    string temp = string.Empty;
    if (inputString[0] == '-') temp = inputString.Substring(1);
    else temp = inputString;
    foreach (char c in temp)
    {
        if (char.IsDigit(c)) counter += Convert.ToInt32(c.ToString());
        else
        {
            onlyDigits = false;
            break;
        }
    }
    if (onlyDigits) System.Console.WriteLine($"Сумма цифр введенного числа = {counter}");
    else System.Console.WriteLine("Введенные символы не образуют число");
}

SummDigitsInText("e130");