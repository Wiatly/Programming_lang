
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Универсальный метод генерации и заполнение двумерного массива
int[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder)
{
    System.Random rand = new System.Random();
    int[,] array2D = new int[countRow, countColumn];

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = rand.Next(topBorder, downBorder + 1);
        }
    }
    return array2D;
}




void Print2DArrayColor(int[,] matrix)
{
    ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.ForegroundColor = col[i % 16];
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "   ".Substring(matrix[i, j].ToString().Length));
        }
        Console.WriteLine();
    }
    Console.ResetColor();
}

// Укороченная сортировка подсчетом
int CountingSort(int[] array)
{
    int max = array.Max();
    int min = array.Min();
    int numstr = -1;

    int[] count = new int[max - min + 1];

    for (int i = 0; i < count.Length; i++)
    {
        count[i] = 0;
    }
    for (int i = 0; i < array.Length; i++)
    {
        if ((array[i] - min) == 0) //перебираем массив, пока не попадем на нулевой элемент вспомогательного массива.
        {                          //Индекс в основном массиве есть номер строки с минимальной суммой.
            numstr = i;
            break;
        }
    }
    return numstr;
}

// Формирование  массива с суммами строк
int[] SortStringArray(int[,] array)
{
    int[] changeString = new int[array.GetLength(0)];
    int summ = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            summ += array[i, j];
        }
        changeString[i] = summ;
        summ = 0;
    }
    return changeString;
}


int row = ReadData("Введите количество строк ");
int column = ReadData("Введите количество столбцов ");
int[,] arr2D = Fill2DArray(row, column, 10, 99);
Print2DArrayColor(arr2D);
Console.WriteLine();
int numStringMinSumm = CountingSort(SortStringArray(arr2D));
Console.WriteLine("Строка с наименьшей суммой строк: " + numStringMinSumm);

