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

void SummDigitsInText_2 (string inputString)  // такой метод задействует меньше ресурсов, т.к. работать будет с int, а не с char или string
{
    int summ = 0;
    int number;
    bool isNumber = int.TryParse(inputString, out number);
    if(isNumber)
    {
        while(number != 0)
        {
            summ += Math.Abs(number) % 10;
            number /= 10;
        }
        System.Console.WriteLine($"Сумма цифр введенного числа = {summ}");
    }
    else System.Console.WriteLine("Введенные символы не образуют число");
}

SummDigitsInText_2("-123");