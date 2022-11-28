// 52.	Написать программу преобразования десятичного числа в двоичное


string Conv_Dec_To_Bin(int inp_dec_num)
{
    string bin_num = string.Empty;
    if (inp_dec_num == 0) return "0";
    else
        while (inp_dec_num != 0)
        {
            bin_num = Convert.ToString(inp_dec_num % 2) + bin_num;
            inp_dec_num /= 2;
        }

        return bin_num;
}

int num = 0;

System.Console.WriteLine(Conv_Dec_To_Bin(num));
