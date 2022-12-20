//using System.Linq;

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


// Сортировка вставками
int[] InsertSort(int[] array)
{
    for (int i = 1; i < array.Length; i++)
    {
        int k = array[i];
        int j = i - 1;

        while (j >= 0 && array[j] > k)
        {
            array[j + 1] = array[j];
            array[j] = k;
            j--;
        }
    }
    return array;
}

// Сортировка подсчетом
int[] CountingSort(int[] array)
{

    int max = array.Max();
    int min = array.Min();

    int[] count = new int[max - min + 1];
    int z = 0;

    for (int i = 0; i < count.Length; i++)
    {
        count[i] = 0;
    }
    for (int i = 0; i < array.Length; i++)
    {
        count[array[i] - min]++;
    }

    for (int i = min; i <= max; i++)
    {
        while (count[i - min]-- > 0)
        {
            array[z] = i;
            z++;
        }
    }

    return array;
}

int arrayCount = int.Parse(ReadData("Введите количество элементов в массиве: "));
int arrayLow = int.Parse(ReadData("Введите нижний порог значений включительно: "));
int arrayUp = int.Parse(ReadData("Введите верхний порог значений включительно: "));
Console.WriteLine();

int[] originalArray = ArrayFill(arrayCount, arrayLow, arrayUp); // заполняем массив
Console.WriteLine("Начальный массив:");
ArrayPrint(originalArray); // печатаем массив
Console.WriteLine();

DateTime beginTime=DateTime.Now;
int[] workArray = BubbleSort(originalArray); // сортируем массив пузырьком
DateTime endTime=DateTime.Now;
Console.WriteLine("Отсортированный пузырьком массив: ");
ArrayPrint(workArray);// печатаем сортированный массив
Console.WriteLine($"Время сортировки: {endTime-beginTime}");
Console.WriteLine();

beginTime=DateTime.Now;
workArray = InsertSort(originalArray); // сортируем массив вставкой
endTime=DateTime.Now;
Console.WriteLine("Отсортированный вставкой массив: ");
ArrayPrint(workArray);// печатаем сортированный массив
Console.WriteLine($"Время сортировки: {endTime-beginTime}");
Console.WriteLine();

beginTime=DateTime.Now;
workArray = CountingSort(originalArray); // сортируем массив подсчетом
endTime=DateTime.Now;
Console.WriteLine("Отсортированный подсчетом массив: ");
ArrayPrint(workArray);// печатаем сортированный массив
Console.WriteLine($"Время сортировки: {endTime-beginTime}");
Console.WriteLine();


