//  1. Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//  и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] MassNums(int row, int column, int from, int to) // Создаем массив, заполненный случайными числами
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to + 1);
    return arr;
}

void Print(int[,] arr) // Выводим массив на экран
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            Console.Write($"{arr[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int  SearcherArray(int[,] arr, int rowInd, int columnInd) // Поиск элемента массива по его индексу
{
    int rows = arr.GetLength(0);
    int columns = arr.GetLength(1);

    if (rows >= rowInd && columns >= columnInd && rowInd >= 0 && columnInd >= 0)
        {
            int result = arr[rowInd, columnInd];
            Console.WriteLine($"The desired element: {result}");
            return result;
        }
    else
        {
            Console.WriteLine("There is no such element at the given position.");
            return -1;
        }
}

// string FindElement(int[,] arr, int f, int s) // Эталонное решение
// {
//     int row = arr.GetLength(0);
//     int column = arr.GetLength(1); 

//     if (f > rows || f <=0 || s > column || s <= 0)
//         return $"{f}, {s} -> not in the array";
//     return $"arr[{f}, {s}] = {arr[f -1, s - 1]} -> is in the array";
// }



Console.Write("Enter the number of rows: ");
int row_num = int.Parse(Console.ReadLine()!);

Console.Write("Enter the number of columns: ");
int column_num = int.Parse(Console.ReadLine()!);

Console.Write("Enter the min number of array: ");
int start = int.Parse(Console.ReadLine()!);

Console.Write("Enter the max number of array: ");
int stop = int.Parse(Console.ReadLine()!);

Console.Write("Enter the first index: ");
int rowIndex = int.Parse(Console.ReadLine()!);

Console.Write("Enter the second index: ");
int columnIndex = int.Parse(Console.ReadLine()!);


int[,] mass = MassNums(row_num, column_num, start, stop);

Print(mass);

Console.WriteLine("Search for the desired element: ");

SearcherArray(mass, rowIndex, columnIndex);

