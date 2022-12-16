string ReadData(string msg)
{
    Console.WriteLine(msg);
    return Console.ReadLine() ?? "0";
}


string calculateEvent(string operation)
{
    // выделяем имена   
    string[] names = operation.Split(',', StringSplitOptions.RemoveEmptyEntries);

    // выбираем жертву
    Random rnd = new Random();
    int linkNum = rnd.Next(names.Length);

    return names[linkNum];

}

string operation = ReadData("Введите имена, разделяя их запятой ");
Console.WriteLine("Сегодня дежурит " + calculateEvent(operation));
