// Заполните массив на случайных чисел от 0 до 9. (вводится с консоли, но не более 8)
// Сформируйте целое число, которое будет состоять из цифр из массива. 
// Старший разряд числа находится на 0-м индексе, а маладший на последнем

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

long StringNum(int[] arr)
{
    string word = "";

    foreach (int number in arr)
    {
        word += number;
    }
    return long.Parse(word);
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

long result = StringNum(mass);
Console.WriteLine();

