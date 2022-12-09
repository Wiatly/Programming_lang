// Решение работает с числами до 28 разрядов - ограниечение Decimal.
// Для больших чисел можно дать решение, аналогичное с решением на семинаре через разбор строки в массив char
// и вывода третьего символа от конца.


Console.Write("Введите число: ");
string? numLine1 = Console.ReadLine();

if (numLine1 != null)
{
    decimal inputNum1 = decimal.Parse(numLine1);


    if (inputNum1 > 99)
    {
        inputNum1 = Math.Round(inputNum1, 0);
        int inputNum2 = (int)(inputNum1 - Math.Floor(inputNum1 / 1000) * 1000);
        Console.WriteLine("Коичество сотен этого числа: " + (inputNum2 / 100));
    }
    else Console.WriteLine("В это числе нет сотен");
}


