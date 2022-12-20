string ReadData(string msg)
{
    Console.WriteLine(msg);
    return Console.ReadLine() ?? "0";
}

// Заполнение массива
int[] ArrayFill(int arrayCount_m, int arrayLow_m, int arrayUp_m)
{
    Random rnd = new Random();
    int[] arrayResult = new int[arrayCount_m];

    for (int i = 0; i < arrayCount_m; i++)
    {
        arrayResult[i] = rnd.Next(arrayLow_m, arrayUp_m + 1);
    }
    return arrayResult;
}

// Печать массива
void ArrayPrint(int[] arrayPrint)
{
    Console.Write("[ ");
    for (int i = 0; i < arrayPrint.Length - 1; i++)
    {
        Console.Write($"{arrayPrint[i]}, ");
    }
    Console.WriteLine($"{arrayPrint[arrayPrint.Length - 1]} ]");

}


// Сортировка пузырьком
int[] BubbleSort(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        for (int j = 0; j < array.Length - 1; j++)
            if (array[j] > array[j + 1])
            {
                int t = array[j + 1];
                array[j + 1] = array[j];
                array[j] = t;
            }
    return array;
}

// Считаем количество четных элементов
int EvenCount(int[] array)
{
    int evenCountSum = 0;
    foreach (int item in array)
    {
        if (item % 2 == 0) evenCountSum++;
    }
    return evenCountSum;
}

int arrayCount = int.Parse(ReadData("Введите количество элементов в массиве: "));
int arrayLow = int.Parse(ReadData("Введите нижний порог значений включительно: "));
int arrayUp = int.Parse(ReadData("Введите верхний порог значений включительно: "));
Console.WriteLine();

int[] workArray = ArrayFill(arrayCount, arrayLow, arrayUp); // заполняем массив
Console.WriteLine("Начальный массив:");
ArrayPrint(workArray); // печатаем массив
workArray = BubbleSort(workArray); // сортируем массив пузырьком
Console.WriteLine("Отсортированный массив: ");
ArrayPrint(workArray);// печатаем сортированный массив
Console.WriteLine();
Console.WriteLine("Количество четных элементов в массиве: " + EvenCount(workArray)); // печатаем количество четных элементов
Console.WriteLine();
