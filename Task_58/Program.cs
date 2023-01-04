
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



// печать двумерного массива
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
            Console.Write(matrix[i, j] + "            ".Substring(matrix[i, j].ToString().Length));
        }
        Console.WriteLine();
    }
    Console.ResetColor();
}

// Умножение двумерных массивов
void Multiply2DArray(int[,] firstArray, int[,] secondArray, int[,] resultArray)
{
    for (int i = 0; i < resultArray.GetLength(0); i++)
    {
        for (int j = 0; j < resultArray.GetLength(1); j++)
        {
            for (int k = 0; k < firstArray.GetLength(1); k++)
            {
                resultArray[i, j] += firstArray[i, k] * secondArray[k, j];
            }
        }
    }
}


int row1 = ReadData("Введите количество строк первой матрицы: ");
int column1 = ReadData("Введите количество столбцов первой матрицы: ");
int row2 = ReadData("Введите количество строк первой матрицы: ");
int column2 = ReadData("Введите количество столбцов первой матрицы: ");
if (column1 != row2) Console.WriteLine("Матрицы не согласованы, умножение не возможно!");
else
{
    int[,] arr2DFirst = Fill2DArray(row1, column1, 10, 99);
    int[,] arr2DSecond = Fill2DArray(row2, column2, 10, 99);
    int[,] result2Darray = new int[row1, column2];
    Print2DArrayColor(arr2DFirst);
    Console.WriteLine();
    Print2DArrayColor(arr2DSecond);
    Console.WriteLine();
    Multiply2DArray(arr2DFirst, arr2DSecond, result2Darray);
    Print2DArrayColor(result2Darray);
    Console.WriteLine();
}

