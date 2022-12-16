string ReadData(string msg)
{
    Console.WriteLine(msg);
    return Console.ReadLine() ?? "0";
}

// возведение в степень
int aPowB(int a, int b)
{
    int result = 1;

    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    return result;
}


int calculateEvent(string operation)
{
    int result = 0;

    // выделяем числа   
    string[] numsAndOperand = operation.Split(new char[] { '+', '-', '*', '/', '^' }, StringSplitOptions.RemoveEmptyEntries);
    // выделяем оператор
    operation = operation.Replace(numsAndOperand[0], "");
    operation = operation.Replace(numsAndOperand[1], "");


    switch (operation)
    {
        case "+":
            result = int.Parse(numsAndOperand[0]) + int.Parse(numsAndOperand[1]);
            break;
        case "-":
            result = int.Parse(numsAndOperand[0]) - int.Parse(numsAndOperand[1]);
            break;
        case "*":
            result = int.Parse(numsAndOperand[0]) * int.Parse(numsAndOperand[1]);
            break;
        case "/":
            result = int.Parse(numsAndOperand[0]) / int.Parse(numsAndOperand[1]);
            break;
        case "^":
            result = aPowB(int.Parse(numsAndOperand[0]), int.Parse(numsAndOperand[1]));
            break;
        default:
            Console.WriteLine("Пока ничего не получилось");
            break;

    }

    return result;
}

Console.WriteLine("Возведение в степень - знак: ^");
string operation = ReadData("Введите вычисление между двумя числами: ");
Console.WriteLine("Результат вычислений: " + calculateEvent(operation));
