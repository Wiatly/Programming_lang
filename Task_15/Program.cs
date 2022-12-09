
Console.Write("Введите число дня недели : ");
string? numLine1 = Console.ReadLine();

if (numLine1 != null)
{
    int inputNum1 = int.Parse(numLine1);


    if (inputNum1 > 0 && inputNum1<8) 
    {
        if (inputNum1 >5) Console.WriteLine("Этот день выходной");
        else Console.WriteLine("Это рабочий день");
    }
    else Console.WriteLine("Нет дня недели с таким номером дня");
}

