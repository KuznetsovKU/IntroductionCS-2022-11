// 91. Даны два слова, можно ли из букв одного слова составить другое слово
//     АБВГ - БГВА

bool Test(string simbols1, string simbols2)
{
    if (simbols1.Length != simbols2.Length) return false;
    else
    {
        char[] simbolsArray1 = simbols1.ToLower().ToCharArray();
        char[] simbolsArray2 = simbols2.ToLower().ToCharArray();
        Array.Sort(simbolsArray1);
        Array.Sort(simbolsArray2);
        simbols1 = new String(simbolsArray1);
        simbols2 = new String(simbolsArray2);
        return simbols1 == simbols2;
    }
}

System.Console.WriteLine(Test("abcd", "dcba"));