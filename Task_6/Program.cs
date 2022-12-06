Console.Write("Введите число: ");
string? numLine_1 = Console.ReadLine();

if (numLine_1 != null)
{
    int inputNum_1 = int.Parse(numLine_1);


    if (inputNum_1 % 2 == 0)
    {
        Console.WriteLine($"Число \t{inputNum_1} ,четное");
    }

    else
    {
        Console.WriteLine($"Число \t{inputNum_1} ,нечетное");
    }

}