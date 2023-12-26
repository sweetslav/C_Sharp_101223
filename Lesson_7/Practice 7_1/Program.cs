// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр. Указание: Использовать рекурсию.

int SumNum(int number)
{
    if (number == 0) return 0;
    return SumNum(number /10) + number % 10;
}

Console.WriteLine(SumNum(123));

