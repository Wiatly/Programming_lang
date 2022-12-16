// Читаем число
string ReadData(string msg)
{
    Console.WriteLine(msg);
    return Console.ReadLine() ?? "0";
}

int SummaDelenie(string numString) // Вычисление с помощью деления
{
    int num = int.Parse(numString);
    int result = 0;
    while (num > 0)
    {
        result = result + num % 10;
        num=num/10;
    }
    return result;
}

int SummaSiblols(string numString) // Вычисление с помощью строки
{
    char[] DigitsArray = numString.ToCharArray();
    int result = 0;
    for (int i = 0; i <= DigitsArray.Length-1; i++)
    {
        result = result + DigitsArray[i]-48;
    }
    return result;
}


string numberForEvent = ReadData("Введите число: ");

DateTime calcTime=DateTime.Now;
Console.WriteLine("Результат вычислений c помощью деления: " + SummaDelenie(numberForEvent));
Console.WriteLine($"Время вычислений c помощью деления: {DateTime.Now-calcTime}");
Console.WriteLine();

calcTime=DateTime.Now;
Console.WriteLine("Результат вычислений c помощью преобразования в массив: " + SummaSiblols(numberForEvent));
Console.WriteLine($"Время вычислений c помощью преобразования в массив: {DateTime.Now-calcTime}");
Console.WriteLine();