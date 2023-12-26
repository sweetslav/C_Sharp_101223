// Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

void Print(int[] arr) // Метод выводит массив
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] MassNums(int size, int from, int to) // Метод создает массив
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(from, to + 1);
    }
    return arr;
}

int[] ReverseArray(int[] arr, int start = 0, int end = -1) // Рекурсивный метод разворачивающий массив
{
    if (end == -1)
        end = arr.Length - 1;

    if (start >= end)
        return arr;

    int temp = arr[start];
    arr[start] = arr[end];
    arr[end] = temp;

    return ReverseArray(arr, start + 1, end - 1);
}

// Добавил обертку для красивого вывода данных

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

int[] reverseMass = ReverseArray(mass);
Console.WriteLine();
Console.WriteLine($"Ваш массив наоборот: ");
Console.WriteLine();
Print(reverseMass);

