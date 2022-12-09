// тип данных String - Строки

string s = "asdf";
System.Console.WriteLine(s[0]);

for (int i = 0; i < s.Length; i++)
{
    System.Console.WriteLine(s[i]);
}

char[] cc = s.ToCharArray();
cc[0] = 'S';
s = new String(cc);

System.Text.StringBuilder
sb = new System.Text.StringBuilder("asda");
sb[0] = 's';
sb = sb.ToString();

for (int i = 0; i < 1000000; i++)
    s = s + "1"; // при каждой итерации создается новая строка и забивает пямять

for (int i = 0; i < 1000000; i++)
    sb.Append("1"); // новая строка НЕ создается на каждой итерации - памяти требуется гораздо меньше


string s1 = "Hello";
string s2 = "Hello";
System.Console.WriteLine(s1 == s2); // сравнивается содержимое не смотря на то, что string - это ссылочный тип данных
System.Console.WriteLine(s1.CompareTo(s2));  // вариант сравнения значений у строк (сравнение посимвольно по величине кода символа)
System.Console.WriteLine(String.Compare(s1, s2));  // вариант сравнения значений у строк (сравнение посимвольно по величине кода символа) с большим количеством перегрузок

string s3 = s1.Substring(2, 4);  // вырезать из строки подстроку со 2-го символа взять 4 символа
System.Console.WriteLine(s1.IndexOf("as"));  // найти индекс вхождения подстроки с строку
string s4 = s1.Replace('a', 'b'); // замена символов


string text = System.Console.ReadLine();
string[] textArray = text.Split(' ');
int[] array = new int[textArray.Length];
for (int i = 0; i < textArray.Length; i++)
{
    array[i] = Convert.ToInt32(textArray[i]);
}


string[] text_2 = System.Console.ReadLine().Split(' ');
int[] array = Array.ConvertAll<string, int>(text_2,Convert.ToInt32);  // обобщенные типы и параметризированные методы
