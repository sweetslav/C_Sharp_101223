// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

void PrintAllNums(int firstNumber, int secondNumber) // Рекурсивный метод вывода всех чисел от M до N
{
    if (firstNumber <= secondNumber)
    {
        Console.Write($"{firstNumber} ");
        if (firstNumber != secondNumber)
        {
            PrintAllNums(firstNumber + 1, secondNumber);
        }
    }
    else /// Добавил вывод результата, при N < M
    {
        Console.Write($"{firstNumber} ");
        PrintAllNums(firstNumber - 1, secondNumber);
    }
}

Console.WriteLine("Input M number: ");
int M = int.Parse(Console.ReadLine()!);

Console.WriteLine("Input N number: ");
int N = int.Parse(Console.ReadLine()!);

PrintAllNums(M, N);

