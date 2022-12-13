// Читаем координаты

string ReadData(string msg)
{
    Console.WriteLine(msg);
    return Console.ReadLine() ?? "0";
}

// Преобразовываем строку в числовые координты
int[] coordArray(string coordPoint)
{
    int[] coordinatsDigit = { 0, 0, 0 };
    // Разделитель - пробел. Можно заменить на запятую, иизменив первый аргумент Split
    string[] coordinats = coordPoint.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    coordinatsDigit[0] = int.Parse(coordinats[0]);
    coordinatsDigit[1] = int.Parse(coordinats[1]);
    coordinatsDigit[2] = int.Parse(coordinats[2]);
    return coordinatsDigit;
}

string coordPoint = ReadData("Введите координаты точки Х, разделите пробелами");
// Получаем координаты точки Х
int[] coordXArray = coordArray(coordPoint);
// Получаем координаты точки Y
coordPoint = ReadData("Введите координаты точки Y, разделите пробелами");
int[] coordYArray = coordArray(coordPoint);

// Считаем рассояние
double Result = Math.Round(
                Math.Sqrt(Math.Pow((coordXArray[0] - coordYArray[0]), 2) +
                          Math.Pow((coordXArray[1] - coordYArray[1]), 2) +
                          Math.Pow((coordXArray[2] - coordYArray[2]), 2))
                          ,2);


Console.WriteLine(Result);
