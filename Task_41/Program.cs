// Подсчитать количество положительных чисел, введенных в консоли посимвольно
// Оставляю все контрольные выводы на экран (в принципе их можно было бы и удалить)


// Ввод строки посимвольно
string ConsoleReadKey()
{
    ConsoleKeyInfo cki;
    string str2 = string.Empty;

    Console.WriteLine("Введите строку символов, ввод завершите нажатием Enter");
    do
    {
        cki = Console.ReadKey();
        str2 = str2 + cki.KeyChar;

    } while (cki.Key != ConsoleKey.Enter);
    return str2;
}



string symbolsString = ConsoleReadKey();

char[] digits = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '-' };
// создаем массив подстрок без цифр и минуса
string[] numsAndOperand = symbolsString.Split(digits, StringSplitOptions.RemoveEmptyEntries);
for (int i = 0; i < numsAndOperand.Length; i++) Console.WriteLine(numsAndOperand[i]);
Console.WriteLine("буквы и символы закончились");

// создаём массив строк из цифр и минуса
numsAndOperand = symbolsString.Split(numsAndOperand, symbolsString.Length - numsAndOperand.Length, StringSplitOptions.RemoveEmptyEntries);
for (int i = 0; i < numsAndOperand.Length; i++) Console.WriteLine(numsAndOperand[i]);

int count = 0;
for (int i = 0; i < numsAndOperand.Length; i++)
{
    if (numsAndOperand[i].StartsWith('-')) count++; // если строка начинается с минуса - точно не положительное
}

// все что осталось содержит положительное число
Console.WriteLine("Количество введенных положительных чисел " + (numsAndOperand.Length - count));
