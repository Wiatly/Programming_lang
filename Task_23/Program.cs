// Читаем координаты

string ReadData(string msg)
{
    Console.WriteLine(msg);
    return Console.ReadLine() ?? "0";
}


string[] stringsForReturn(int numberForEvent)
{
    string[] forReturn = { string.Empty, string.Empty, string.Empty };
    string LineNumbers = "| ";
    string LineQubes = "| ";
    string upperString = new string('-', LineQubes.Length);

    for (int i = 1; i <= numberForEvent; i++)
    {
        // строим строку кубов
        LineQubes = LineQubes + i * i * i + "| ";
        // строим строку значений
        LineNumbers = LineNumbers + new string(' ', (int)Math.Log10(i * i * i) - (int)Math.Log10(i)) + i + "| ";

    }

    // строим строку разделителей
    upperString = new string('-', LineQubes.Length - 1);

    //возврат значений из метода
    forReturn[0] = upperString;
    forReturn[1] = LineNumbers;
    forReturn[2] = LineQubes;
    return forReturn;
}


int numberForEvent = int.Parse(ReadData("Введите число"));
string[] outFinal = stringsForReturn(numberForEvent);

Console.WriteLine("Таблица кубов:");
Console.WriteLine(outFinal[0]);
Console.WriteLine(outFinal[1]);
Console.WriteLine(outFinal[0]);
Console.WriteLine(outFinal[2]);
Console.WriteLine(outFinal[0]);



