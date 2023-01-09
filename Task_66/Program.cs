
// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}


int RecMN(int M, int N)
{
    int outRes = 0;
    if (M >= N) return outRes + N;
    outRes = M + RecMN(M + 1, N);
    return outRes;
}

int number1 = ReadData("Введите число M: ");
int number2 = ReadData("Введите число N: ");
int resultLine = number1 < number2 ? RecMN(number1, number2) : RecMN(number2, number1);
Console.WriteLine($"Сумма натуральных чисел между {number1} и {number2}: {resultLine}");
