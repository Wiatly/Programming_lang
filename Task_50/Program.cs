int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Заполняем числами Фибоначчи
int[,] Fill2DIndexed(int countRow, int countColumn)
{
    int[,] array2D = new int[countRow, countColumn];
    int[] numFib = { 0, 1 };
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = numFib[0];
            numFib[0] = numFib[1];
            numFib[1] = array2D[i, j] + numFib[1];
        }
    }

    return array2D;
}

void Print2DArrayColor(int[,] matrix, int[] cellCeck)
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
            if (i == cellCeck[0] - 1 && j == cellCeck[1] - 1) Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(matrix[i, j] + "            ".Substring(matrix[i, j].ToString().Length));
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}

int row = ReadData("Введите количество строк ");
int column = ReadData("Введите количество столбцов ");
int[,] arr2D = Fill2DIndexed(row, column);

int[] cellCheck = { 0, 0 };
cellCheck[0] = ReadData("Введите количество номер строки ячеки, которую подсветить ");
cellCheck[1] = ReadData("Введите количество номер столбца ячеки, которую подсветить ");

Print2DArrayColor(arr2D, cellCheck);

if (cellCheck[0] > row || cellCheck[1] > column) Console.WriteLine("Указанной ячейки в массиве не существует.");