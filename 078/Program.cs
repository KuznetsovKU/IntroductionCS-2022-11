﻿// 78.	В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». 
//      Покажите все слова (слова не обязательно осмысленные), состоящие из n букв, которые можно построить из букв этого алфавита


void MakeWords(string alphabet, int wordLength, string outputWord = "")  // outputWord внесен сюда, чтобы не передавать его отдельно как агрумент
{
    if (wordLength == 0)
    {
        System.Console.Write($"{outputWord} ");  // выводим слово в консоль
        return;                                  // оператор НЕОБХОДИМ для прекращения формирования слова. Иначе произойдет зацикливание
    }
    foreach(char c in alphabet)                  // пробегаем по каждому символу "алфавита" рукурсивно углубляясь в зависимости от количества букв в слове
    {
        outputWord += c;                         //  собираем слово
        MakeWords(alphabet, wordLength - 1, outputWord);        // рекурсивный запуск метода для каждой последующей буквы слова (переход на последующие буквы)
        outputWord = outputWord.Remove(outputWord.Length - 1);  // удаление последней буквы слова для подстановки новой не следующем вызове рекурсии
    }
    System.Console.WriteLine();                  // разделение перебора на блоки (только для удобства чтения)
}

MakeWords("аисвп", 3);
