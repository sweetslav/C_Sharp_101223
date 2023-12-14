// Задайте одномерный массив, заполненный случайными числами.
// Определите количество простых чисел в этом массиве.

void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");        
    }
    Console.WriteLine();
}

int[] MassNums(int size, int from, int to)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(from, to + 1);
    }
    return arr;
}

bool isPrime(int number)
{
    if (number < 2)
        return false;
    
    for (int i = 2; i <= Math.Sqrt(number); i++)
    {
        if (number % i == 0)
            return false;
    }
    return true;
}

int SimpleNum(int[] arr)
{
    int count = 0;

    foreach (int number in arr)
    {
        if (isPrime(number))
            count++;
    }
    return count;
}


Console.WriteLine("Введите размер массива");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите начало массива");
int start = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите конец массива");
int stop = int.Parse(Console.ReadLine()!);

int[] mass = MassNums(num, start, stop);
Console.WriteLine();
Console.WriteLine($"Ваш массив размером: {num} чисел. От: {start} до: {stop}");
Console.WriteLine();
Print(mass);

int result = SimpleNum(mass);
Console.WriteLine(result);
