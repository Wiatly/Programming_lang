string ReadData(string msg)
{
    Console.WriteLine(msg);
    //return Console.ReadLine();
    return Console.ReadLine() ?? "0";
}


string readStringNum = ReadData("Введите пятизначное число");

int stringLenght = readStringNum.Length;

for (int i = 0; i < stringLenght / 2; i++)
{
    if (readStringNum.Substring(i, 1) != readStringNum.Substring(stringLenght - 1 - i, 1))
    {
        Console.WriteLine("Не полиндром");
        break;
    }
    else if (i + 1 == stringLenght / 2)
    {
        Console.WriteLine("Полиндром");
    }
}


