// Со звездочкой не сделал.

// Алгоритмически решение выглядит следующим образом:
// создается метод для подсчета главной диагонали: условие  i==j;
// далее матрица сдвигается налево для праводго верхнего треугольника и считаются главные диагонали;
//                          вверх для левого нижнего треугольника и считаются главные диагонали.
// 



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

    Console.ForegroundColor = ConsoleColor.DarkYellow;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            Console.Write(matrix[i, j] + "          ".Substring(matrix[i, j].ToString().Length));

        }
        Console.WriteLine();
    }
    Console.ResetColor();
}

void AverageSumm(int[,] matrix)
{
    int summ = 0;
    Console.ForegroundColor = ConsoleColor.Green;

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            summ += matrix[i, j];
        }

        double averageSum=Math.Round(Convert.ToDouble(summ)/Convert.ToDouble(matrix.GetLength(0)),2);
        Console.Write(averageSum + "          ".Substring(averageSum.ToString().Length));
        summ = 0;
    }
    Console.ResetColor();
}


int row = ReadData("Введите количество строк ");
int column = ReadData("Введите количество столбцов ");
int[,] arr2D = Fill2DArray(row, column, 10, 99);
Print2DArrayColor(arr2D);
Console.WriteLine();
AverageSumm(arr2D);