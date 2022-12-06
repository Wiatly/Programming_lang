Console.Write("Введите число: ");
string? numLine_1 = Console.ReadLine();
int evenNum = 2;

if (numLine_1 != null)
{
    int inputNum_1 = int.Parse(numLine_1);
    if (inputNum_1 >= 2)
    {
        do
        {
            Console.Write(evenNum);
            Console.Write(", ");
            evenNum = evenNum + 2;
        }
        while (evenNum < inputNum_1);
        if (inputNum_1 % 2 == 0) Console.Write(evenNum);
    }
    else Console.WriteLine("Введеное число меньше 2");


}