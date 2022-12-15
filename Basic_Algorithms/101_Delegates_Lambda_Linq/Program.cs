// 89. Подсчитать сумму цифр, встречающихся в строке

// string text = "12345";
// int summ = text.ToCharArray(). .Sum();
// System.Console.WriteLine(summ);

// Делегаты

// int CountDigits(string inputText)
// {
//     int counter = 0;
//     foreach(char c in inputText)
//     {
//         if (char.IsDigit(c)) counter++;
//     }
//     return counter;
// }

// System.Console.WriteLine(CountDigits("12345"));


// int CountLatin(string inputText)
// {
//     int counter = 0;
//     foreach(char c in inputText)
//     {
//         if (c >= 'A' && c <= 'Z' || c >= 'a' && c <= 'z') counter++;
//     }
//     return counter;
// }

// int CountRus(string inputText)
// {
//     int counter = 0;
//     foreach(char c in inputText)
//     {
//         if (c >= 'А' && c <= 'Я' || c >= 'а' && c <= 'я' || c == 'Ё' || c == 'ё') counter++;
//     }
//     return counter;
// }

using System.Linq; // команда была обязательной в предыдущих версиях C#. теперь подключается автоматически
delegate bool IsChar(char c);
class Program
{
    static int CountChars(string inputText, IsChar isChar)
    {
        int counter = 0;
        foreach(char c in inputText)
        {
            if (isChar(c)) counter++;
        }
        return counter;
    }

    static bool IsLatin(char c)
    {
        return (c >= 'A' && c <= 'Z' || c >= 'a' && c <= 'z');
    }

    static bool IsRus(char c)
    {
        return (c >= 'А' && c <= 'Я' || c >= 'а' && c <= 'я' || c == 'Ё' || c == 'ё');
    }

    static void Main()
    {
        string text1 = "Эта строка содержит latinskie буквы и цифры(12345)";
        System.Console.WriteLine(CountChars(text1, IsLatin));
        System.Console.WriteLine(CountChars(text1, IsRus));
        System.Console.WriteLine(CountChars(text1, char.IsDigit));

        // => Лямбда-выражения
        System.Console.WriteLine(CountChars(text1, 
        delegate(char c)  // анонимный делегат (при необходимости обратиться к условию делегата однократно (вместо создания отдельных методов))
        {
            return (c >= 'A' && c <= 'Z' || c >= 'a' && c <= 'z');
        }
        ));

        System.Console.WriteLine(CountChars(text1, 
        (c)=>  // лямбда-выражение многострочное (преобразование анонимного делегата)
        {
            return (c >= 'A' && c <= 'Z' || c >= 'a' && c <= 'z');
        }
        ));

        System.Console.WriteLine(CountChars(text1, 
        (c) => c >= 'A' && c <= 'Z' || c >= 'a' && c <= 'z' // лямбда-выражение однострочное (преобразование анонимного делегата)
        ));
        // Лямбда-выражения чаще всего используют для определения каких-либо условий отбора, или преобразований

        // Linq
        var query = (from n in text1 where (n >= 'A' && n <= 'Z' || n >= 'a' && n <= 'z') select n).Count();
        var summ1 = (from n in text1 where char.IsDigit(n) select char.GetNumericValue(n)).Sum();
        System.Console.WriteLine(summ1);
    }
}