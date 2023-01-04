
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

void Print2DArrayColor(string[,] matrix)
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
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.ResetColor();
}

void CreateArray(string[,] array)
{
    int temp = array.GetLength(0) * array.GetLength(1);

    int count = 1;    //максимальное количество знаков
    while (temp >= 10) //считаем максимальное количество знаков
    {
        count++;
        temp = temp / 10;
    }
    string s = new string('0', count); 


    count = 1;        // сквозной счеткик массива
    int i = 0;            //номер строки
    int j = 0;            //номер столбца
 
    for (count = 1; count < array.GetLength(0) * array.GetLength(1)+1; count++)
    {
        array[i, j] = s.Substring(count.ToString().Length) + count;

        if (i <= j + 1 && i + j < array.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= array.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > array.GetLength(1) - 1)
            j--;
        else
            i--;
    }
}

int x = ReadData("Введите размер матрицы:  ");
Console.WriteLine($"");

string[,] array2D = new string[x, x];
CreateArray(array2D);
Print2DArrayColor(array2D);
