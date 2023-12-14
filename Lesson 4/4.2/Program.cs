// Задайте массив из N натуральных чисел (N вводится с клавиатуры).
// Найдите количество чисел, которые оканчиваются на 1 и делятся нацело на 7.

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

void SelectionSort(int[] array)
{
    for(int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for(int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition])
                minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

int CountNum(int[] arr)
{
    int count = 0;

    foreach (int number in arr)
    {
        if (number % 10 == 1 && number % 7 == 0)
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
SelectionSort(mass);
Print(mass);

int result = CountNum(mass);
Console.WriteLine();

Console.WriteLine($"Количество чисел, оканчивающихся на 1 и делящихся на 7: {result}");
Console.WriteLine();

