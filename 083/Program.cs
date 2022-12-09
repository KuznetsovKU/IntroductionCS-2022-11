// 83. Подсчитать количество цифр среди вводимых с клавиатуры символов

int CountDigitsInText(string inputString)
{
    int counter = 0;
    foreach (char c in inputString)
    {
        if (char.IsDigit(c)) counter++;
    }
    return counter;
}

System.Console.WriteLine(CountDigitsInText("П0дс41тать к0л14ест80 ц1фр сред1 880д1мых с кла81атуры с1м80л08"));