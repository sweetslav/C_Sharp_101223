//  Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
//  Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

int SumOfDigits(int number)
{
    int sum = 0;
    while (number != 0)
    {
        sum = sum + number % 10;
        number /= 10;
    }
    return sum;
}

bool isSumEven(int number)
{
    int sum = SumOfDigits(number);

    if (sum % 2 == 0)
        return true;
    else
        return false;
}


Console.WriteLine("Введите число или 'q' для выхода:");
string input = Console.ReadLine()!;

while (input != "q")
{
    int a = int.Parse(input);
    int sumResult = SumOfDigits(a);
    Console.WriteLine($"Сумма цифр числа {a}: {sumResult}");
    bool evenResult = isSumEven(a);

    Console.WriteLine($"Сумма цифр числа {a} является чётным? {evenResult}");

    if (evenResult)
    {
        Console.WriteLine("Сумма цифр чётная.");
        Console.WriteLine("До свидания!");
        break;
    }

    Console.WriteLine("Введите число или 'q' для выхода:");
    input = Console.ReadLine()!;
}
