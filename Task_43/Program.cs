// Читаем координаты

string ReadData(string msg)
{
    Console.WriteLine(msg);
    return Console.ReadLine() ?? "0";
}

// Считаем точки пересечения
double[] CrossCoordinats(double[] firstLineKoeff, double[] secondLineKoeff)
{
    double[] crossLinesPoint = new double[2] { 0, 0 };

    crossLinesPoint[0] = Convert.ToDouble((secondLineKoeff[1] - firstLineKoeff[1]) / (firstLineKoeff[0] - secondLineKoeff[0]));
    crossLinesPoint[1] = (firstLineKoeff[0] * (crossLinesPoint[0]) + firstLineKoeff[1]);

    return crossLinesPoint;
}

// Считаем рассояние
double SideLenght(double[] coordXArray,double[] coordYArray)
{
double result = Math.Sqrt(Math.Pow((coordXArray[0] - coordYArray[0]), 2) +
                          Math.Pow((coordXArray[1] - coordYArray[1]), 2));
return result;
}

double[] koeff1Line = new double[2] { 0, 0 };
double[] koeff2Line = new double[2] { 0, 0 };
double[] koeff3Line = new double[2] { 0, 0 };

Console.WriteLine("Введите коэффициенты К и В линейного уравнения вида y= K*x + b");
koeff1Line[0] = double.Parse(ReadData("Введите Коэффициент K первого уравнения"));
koeff1Line[1] = double.Parse(ReadData("Введите Коэффициент b первого уравнения"));
Console.WriteLine($"Первое уравнение: y= {koeff1Line[0]}*x + {koeff1Line[1]}");
koeff2Line[0] = double.Parse(ReadData("Введите Коэффициент K второго уравнения"));
koeff2Line[1] = double.Parse(ReadData("Введите Коэффициент b второго уравнения"));
Console.WriteLine($"Второе уравнение: y= {koeff2Line[0]}*x + {koeff2Line[1]}");
koeff3Line[0] = double.Parse(ReadData("Введите Коэффициент K третьего уравнения"));
koeff3Line[1] = double.Parse(ReadData("Введите Коэффициент b третьего уравнения"));
Console.WriteLine($"Третье уравнение: y= {koeff3Line[0]}*x + {koeff3Line[1]}");

// Координаты пересечения
double[] firstCrossCoord = CrossCoordinats(koeff1Line, koeff2Line);
Console.WriteLine("Точка пересечения первой и второй прямых: ("+firstCrossCoord[0]+","+firstCrossCoord[1]+")");
double[] secondCrossCoord = CrossCoordinats(koeff2Line, koeff3Line);
Console.WriteLine("Точка пересечения первой и второй прямых: ("+secondCrossCoord[0]+","+secondCrossCoord[1]+")");
double[] thirdCrossCoord = CrossCoordinats(koeff3Line, koeff1Line);
Console.WriteLine("Точка пересечения первой и второй прямых: ("+thirdCrossCoord[0]+","+thirdCrossCoord[1]+")");

// Получаем длины сторон и полусумму сторон

double side1Lenght = SideLenght(firstCrossCoord,secondCrossCoord);
double side2Lenght = SideLenght(secondCrossCoord,thirdCrossCoord);
double side3Lenght = SideLenght(thirdCrossCoord,firstCrossCoord);
double halfSummSides=(side1Lenght+side2Lenght+side3Lenght)/2;

// Площадь треугольника
double areaTriangle = Math.Sqrt(halfSummSides*(halfSummSides -side1Lenght)*
                                (halfSummSides -side2Lenght)*
                                (halfSummSides -side3Lenght));

Console.WriteLine("Площадь треугольника: " + areaTriangle);                           

