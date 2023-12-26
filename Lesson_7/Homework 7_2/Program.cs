// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. 

int Ackermann(int firstNumber, int secondNumber)
{
    if (firstNumber == 0)
    {
        return secondNumber + 1;
    }
    else if (firstNumber > 0 && secondNumber == 0)
    {
        return Ackermann(firstNumber - 1, 1);
    }
    else
    {
        return Ackermann(firstNumber - 1, Ackermann(firstNumber, secondNumber - 1));
    }
}

Console.WriteLine("Input M number: ");
int M = int.Parse(Console.ReadLine()!);

Console.WriteLine("Input N number: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine();
int result = Ackermann(M, N);
Console.WriteLine($"Result of the Ackermann function evaluation is: {result}");
Console.WriteLine();


