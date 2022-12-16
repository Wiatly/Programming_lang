// Читаем координаты

string ReadData(string msg)
{
    Console.WriteLine(msg);
    return Console.ReadLine() ?? "0";
}

int[] arrayFill(int arrayCount_m, int arrayLow_m, int arrayUp_m)
{
    Random rnd = new Random();
    int[] arrayResult = new int[arrayCount_m];

    for (int i = 0; i < arrayCount_m; i++)
    {
        arrayResult[i] = rnd.Next(arrayLow_m, arrayUp_m + 1);
    }
    return arrayResult;
}

void arrayPrint(int[] arrayPrint)
{
    Console.Write("[ ");
    for (int i = 0; i < arrayPrint.Length - 1; i++)
    {
        Console.Write($"{arrayPrint[i]}, ");
    }
    Console.WriteLine($"{arrayPrint[arrayPrint.Length - 1]} ]");

}


int arrayCount = int.Parse(ReadData("Введите количество символов в массиве: "));
int arrayLow = int.Parse(ReadData("Введите нижний порог значений включительно: "));
int arrayUp = int.Parse(ReadData("Введите верхний порог значений включительно: "));

arrayPrint(arrayFill(arrayCount,arrayLow,arrayUp));

