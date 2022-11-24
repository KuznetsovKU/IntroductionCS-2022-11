// 

void Swap (ref int arg1, ref int arg2)  // reference - ссылка
{
    int temp = arg1;
    arg1 = arg2;
    arg2 = temp;
}

void Calculator(int arg1, int arg2, ref int sum, ref int multi)  // префикс ref добавляется только тем переменным, значение которых нам надо перезаписать относительно начального
{
    sum = arg1 + arg2;
    multi = arg1 * arg2;
}

int num1 = 5, num2 = 7;
System.Console.WriteLine($"num1 = {num1}, num2 = {num2}");
Swap(ref num1, ref num2);  // аргументы в метод передаются также с префиксом ref. Иначе код не скомпилируется
System.Console.WriteLine($"num1 = {num1}, num2 = {num2}");

int sum, multi;  // если переменной не присвоено изначальное значение, использовать ее не получится (код не скомпилируется)
sum = 0;         // тут мы как раз присваиваем начальные значения
multi = 0;       // и тут тоже присваиваем
Calculator(num1, num2, ref sum, ref multi);
System.Console.WriteLine($"sum = {sum}, multi = {multi}");

void Calculator2(int arg1, int arg2, out int sum2, out int multi2)  // префикс out позволяет работать с переменными, которым не присвоено начальное значение
{
    sum2 = arg1 + arg2;
    multi2 = arg1 * arg2;
}

int sum2, multi2;
Calculator2(num1, num2, out sum2, out multi2);  // передача аргументов в метод в таком случае также производится с префиксами out
System.Console.WriteLine($"sum2 = {sum2}, multi2 = {multi2}");

