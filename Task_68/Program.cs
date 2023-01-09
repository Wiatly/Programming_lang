
// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}


long Ackerman(long m, long n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Ackerman(m - 1, 1);
  else return Ackerman(m - 1, Ackerman(m, n - 1));
}

long number1 = ReadData("Введите число m: ");
long number2 = ReadData("Введите число n: ");
long result=Ackerman(number1,number2);
Console.WriteLine($"Значение функции Аккермана: {result}");
