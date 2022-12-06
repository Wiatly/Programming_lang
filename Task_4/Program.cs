Console.Write("Введите первое число: ");
string? numLine_1 = Console.ReadLine();
Console.Write("Введите второе число: ");
string? numLine_2 = Console.ReadLine();
Console.Write("Введите третье число: ");
string? numLine_3 = Console.ReadLine();

if (numLine_1 != null && numLine_2 != null && numLine_3 != null)
{
    int inputNum_1 = int.Parse(numLine_1);
    int inputNum_2 = int.Parse(numLine_2);
    int inputNum_3 = int.Parse(numLine_3);


    if (inputNum_1 > inputNum_2)
    {
        if (inputNum_1 > inputNum_3) Console.WriteLine($"Первое число \t{inputNum_1} ,самое большое");
        else { Console.WriteLine($"Третье число \t{inputNum_3} ,самое большое"); }
    }
    else
    {
        if (inputNum_2 > inputNum_3) Console.WriteLine($"Второе число \t{inputNum_2} ,самое большое");
        else { Console.WriteLine($"Третье число \t{inputNum_3} ,самое большое"); }
    }
}