// Обмен значений двух переменных

int num1 = 5;
int num2 = 7;
System.Console.WriteLine($"num1 = {num1}, num2 = {num2}");

/*
#region Classic case (with third variable)

int numTemp;
numTemp = num1;
num1 = num2;
num2 = numTemp;
System.Console.WriteLine($"num1 = {num1}, num2 = {num2}");
    
#endregion
*/

/*
#region Second case (with summary)

num1 = num1 + num2;
num2 = num1 - num2;
num1 = num1 - num2;
System.Console.WriteLine($"num1 = {num1}, num2 = {num2}");
    
#endregion
*/

#region Third case (learn independetly)

num1 = num1 ^ num2;
num2 = num1 ^ num2;
num1 = num1 ^ num2;
System.Console.WriteLine($"num1 = {num1}, num2 = {num2}");

#endregion
