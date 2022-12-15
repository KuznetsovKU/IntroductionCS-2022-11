// 90. Есть два массива info и data.
//     Массив data состоит из нулей и единиц хранящий числа в двоичном представлении. Числа идут друг за другом без разделителей.
//     Массив info состоит из чисел, которые представляют количество бит чисел из массива data.
//     Составить массив десятичных представлений чисел массива data с учётом информации из массива info.

int[] data = { 0, 1, 1, 1, 1, 0, 0, 0, 1 };
int[] info = { 2, 3, 3, 1 };

int ConvertBinToDec(int[] binarylNum, int bitCount)
{
    int decimalNum = 0;
    for (int i = 0; i < binarylNum.Length; i++)
    {
        decimalNum += binarylNum[i] * Convert.ToInt32(Math.Pow(2, bitCount - (i + 1)));
    }
    return decimalNum;
}

int[] FindDecimal(int[] binArray, int[] bitKey)
{
    if (binArray.Length == bitKey.Sum())  // исключаем возможное нессответствие количества элементов в data сумме элементов (сумма битов) в info
    {
        int[] decimalArray = new int[bitKey.Length];
        {
            for (int i=0;i<decimalArray.Length;i++)
            {
                int[] tempBinArray = new int[bitKey[0]];
                tempBinArray = binArray[0..bitKey[0]];
                decimalArray[i] = ConvertBinToDec(tempBinArray, bitKey[0]);
                binArray = binArray[bitKey[0]..];
                bitKey = bitKey[1..];
            }
        }
        return decimalArray;
    }
    else throw new ArgumentException("Проверьте корректность аргументов");
}

void PrintArray(int[] arrayToPrint)
{
    foreach(int element in arrayToPrint) System.Console.Write($"{element}, ");
    System.Console.WriteLine();
}

PrintArray(FindDecimal(data, info));