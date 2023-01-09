// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Печать результата
void PrintResult(string prefix)
{
    Console.WriteLine(prefix);
}

string LineGenRec(int num)
{
    if (num <= 0)
    {
        return string.Empty;
    }
    else
    {
        string outLine = num + " " + LineGenRec(num - 1);
        return outLine;
    }
}

int number = ReadData("Введите число N: ");
string resultLine = LineGenRec(number);
PrintResult(resultLine);