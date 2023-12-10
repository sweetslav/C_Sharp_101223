// Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100. Найдите количество элементов массива, значения которых лежат в отрезке [20,90].

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

int[] array = new int[10];


// Решение задачи

FillArray(array);
SelectionSort(array);
PrintArray(array);
Console.WriteLine();

int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] >= 20 && array[i] <= 90)
    {
        count++;
    }
}

Console.WriteLine($"Количество элементов в отрезке [20, 90]: {count}");
