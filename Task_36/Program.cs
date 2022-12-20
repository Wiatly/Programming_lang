// Вывести все пары в массиве

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

// Печать двумерного массива
void Array2DPrint(int[,] arrayPrint)
{
    string string1 = "[ ";
    string string2 = "[ ";

    int i = 0;
    for (i = 0; i < arrayPrint.GetLength(1) - 1; i++)
    {
        string1 = string1 + arrayPrint[0, i] + ", ";
        string2 = string2 + arrayPrint[1, i] + ", ";
    }
    Console.WriteLine(string1 + arrayPrint[0, i] + " ]");
    Console.WriteLine(string2 + arrayPrint[1, i] + " ]");

}


// Сортировка пузырьком, формирование двумерного массива
int[,] BubbleSort(int[] array)
{
    int[,] arrayWithIndex = new int[2, array.Length];
    for (int i = 0; i < array.Length; i++) // заполняем двумерный массив: верх значения, низ индексы
    {
        arrayWithIndex[0, i] = array[i];
        arrayWithIndex[1, i] = i;
    }

    for (int i = 0; i < array.Length; i++) // сортируем по значениям
        for (int j = 0; j < array.Length - 1; j++)
            if (arrayWithIndex[0, j] > arrayWithIndex[0, j + 1])
            {
                int t = arrayWithIndex[0, j + 1];
                arrayWithIndex[0, j + 1] = arrayWithIndex[0, j];
                arrayWithIndex[0, j] = t;

                int t1 = arrayWithIndex[1, j + 1];
                arrayWithIndex[1, j + 1] = arrayWithIndex[1, j];
                arrayWithIndex[1, j] = t1;
            }
    return arrayWithIndex;
}

// вывод пар
void PairPrint(int[,] arrayCheck)
{
    int i = 0;
    bool findIt = false;

    while (i < arrayCheck.GetLength(1) - 1)
    {
        if (arrayCheck[0, i] == arrayCheck[0, i + 1])
        {
            Console.WriteLine($"Пара чисел {arrayCheck[0, i]} на позициях {arrayCheck[1, i]} и {arrayCheck[1, i + 1]}");
            i = i + 2;
            findIt = true;
        }
        else i++;
    }
    if (!findIt) Console.WriteLine("Пар не найдено.");
}


int arrayCount = int.Parse(ReadData("Введите количество элементов в массиве: "));
int arrayLow = int.Parse(ReadData("Введите нижний порог значений включительно: "));
int arrayUp = int.Parse(ReadData("Введите верхний порог значений включительно: "));
Console.WriteLine();

int[] workArray = ArrayFill(arrayCount, arrayLow, arrayUp); // заполняем массив
Console.WriteLine("Начальный массив:");
ArrayPrint(workArray); // печатаем массив
int[,] work2DArray = BubbleSort(workArray); // сортируем массив пузырьком
Console.WriteLine("Отсортированный массив с индексами: ");
Array2DPrint(work2DArray);// печатаем сортированный массив
Console.WriteLine("Найдены следующие пары: ");
PairPrint(work2DArray); // печатаем найденные пары
