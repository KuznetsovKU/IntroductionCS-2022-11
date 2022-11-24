// Списки

List<int> temperature;
temperature = new List<int>();  // в () можно поместить предполагаемое количество элементов списка, чтобы сразу выделить память под них (не обязательно)
int sum = 0;
for (int i = 0; i < 7; i++)
{
    temperature.Add(Convert.ToInt32(Console.ReadLine()));
    sum += temperature[i];
}

System.Console.WriteLine(sum / temperature.Count);  // длина (количество элеменов) списка выводится через свойство .Count