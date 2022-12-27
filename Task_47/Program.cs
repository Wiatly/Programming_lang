double ReadData(string line)
{
    Console.Write(line);
    double number = double.Parse(Console.ReadLine() ?? "0");
    return number;
}

double NextDouble(double minValue, double maxValue)
{
    System.Random rand = new System.Random();
    return rand.NextDouble() * (maxValue - minValue) + minValue;
}

// Универсальный метод генерации и заполнение двумерного массива
double[,] Fill2DArray(int countRow, int countColumn, double minValueFill, double maxValueFill)
{
    //  System.Random rand = new System.Random();
    double[,] array2D = new double[countRow, countColumn];

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = Math.Round(NextDouble(minValueFill, maxValueFill), 2);
        }
    }
    return array2D;
}



void Print2DArrayColor(double[,] matrix)
{
    ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.ForegroundColor = col[Math.Abs((i - j)) % 16];
            Console.Write(matrix[i, j] + "          ".Substring(matrix[i, j].ToString().Length));
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}


int row = Convert.ToInt32(ReadData("Введите количество строк "));
int column = Convert.ToInt32(ReadData("Введите количество столбцов "));
double minValueArray = ReadData("Введите минимальное значение массива ");
double maxValueArray = ReadData("Введите максимальное значение ");

double[,] arr2D = Fill2DArray(row, column, minValueArray, maxValueArray);
Print2DArrayColor(arr2D);