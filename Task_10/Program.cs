Console.Write("Введите трёхзначное число: ");
string? numLine1 = Console.ReadLine();

if (numLine1 != null)
{
    int inputNum1 = int.Parse(numLine1);

    if (inputNum1>99 && inputNum1<1000) Console.WriteLine("Вторая цифра этого числа: " + (inputNum1 - (inputNum1/100)*100)/10);
    else Console.WriteLine("Это не трёхзначное число");


 }