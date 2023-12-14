//  Задача 2: Задайте массив заполненный случайными трёхзначными числами. 
//  Напишите программу, которая покажет количество чётных чисел в массиве.

void Print(int[] arr) // Вывод массива
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] MassNums(int size) // Создание массива ТРЕХЗНАЧНЫХ чисел
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(100, 999);
    }
    return arr;
}

void SelectionSort(int[] array) // Сортировка массива
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

int EvenNum(int[] arr) // Подсчёт четных
{
    int count = 0;

    foreach (int number in arr)
    {
        if (number % 2 == 0)
            count++;
    }
    return count;
}

Console.WriteLine("Введите размер массива");
int num = int.Parse(Console.ReadLine()!);

int[] mass = MassNums(num);
SelectionSort(mass);
Print(mass);

int result = EvenNum(mass);
Console.WriteLine();

Console.WriteLine($"Количество четных чисел: {result}");
Console.WriteLine();


