// Задача 2: Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.

void FillArray(int[] collection) // Метод для заполнения массива числами
{
    int length  = collection.Length;
    int index = 0;

    while(index < length)
    {
        collection[index] = new Random().Next(1, 100);
        index++; 
    }
}

void PrintArray(int[] col) // Метод для ввывода массива
{
    int count = col.Length; 
    int position = 0;

    while(position < count)
    {
        Console.Write(col[position] + ", ");
        position++;
    }
}

void SelectionSort(int[] array) // Метод для сортировки массива
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

// Решение задачи

int[] array = new int[10];

FillArray(array);
SelectionSort(array);
PrintArray(array);
Console.WriteLine();

int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        count++;
    }
}

Console.WriteLine($"Количество четных чисел: {count}");