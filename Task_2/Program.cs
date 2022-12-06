string? numLine_1 = Console.ReadLine();
string? numLine_2 = Console.ReadLine();

if (numLine_1 != null && numLine_2 != null)
{
    int inputNum_1 = int.Parse(numLine_1);
    int inputNum_2 = int.Parse(numLine_2);


    if (inputNum_1 > inputNum_2)
    {
        Console.WriteLine($"Первое число \t{inputNum_1} ,больше второго {inputNum_2}");
    }
    else
    {
        Console.WriteLine($"Второе число \t{inputNum_2} ,больше пераого {inputNum_1}");
    }
}