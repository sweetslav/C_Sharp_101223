// Задача 2: Задайте двумерный массив. 
// Напишите программу, которая поменяет местами первую и последнюю строку массива.

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
            {
            Console.Write($"{arr[i, j]} ");
            }
        Console.WriteLine();
        }
    Console.WriteLine();
}

void SwapArray(int[,] arr) // Замена строк в двумерном массиве
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    int[] temp = new int[column];

    for (int i = 0; i < column; i++)
    {
        temp[i] = arr[0, i];
    }

    for (int i = 0; i < column; i++)
    {
        arr[0, i] = arr[row - 1, i];
    }

    for (int i = 0; i < column; i++)
    {
        arr[row - 1, i] = temp[i];
    }
}

Console.Write("Enter the number of rows: ");
int row_num = int.Parse(Console.ReadLine()!);

Console.Write("Enter the number of columns: ");
int column_num = int.Parse(Console.ReadLine()!);

Console.Write("Enter the min number of array: ");
int start = int.Parse(Console.ReadLine()!);

Console.Write("Enter the max number of array: ");
int stop = int.Parse(Console.ReadLine()!);
Console.WriteLine();

int[,] mass = MassNums(row_num, column_num, start, stop);

Print(mass);
SwapArray(mass);
Print(mass);


// int[] FindRowArray(int[,] arr, int row) // отделить строку от двумерного массива
//     {
//     int rowLength = arr.GetLength(1);
//     int[] result = new int[rowLength];
//     for (int i = 0; i < rowLength; i++)
//     {
//         result[i] = arr[row, i];
//     }
//     return result;
//     }

// void SwapArray(int[,] arr) // заменить строки двумерного массива
// {
//     int row = arr.GetLength(0);
//     int column = arr.GetLength(1);

//     int[] firstRow = FindRowArray(arr, 0);
//     int[] lastRow = FindRowArray(arr, row - 1);

//     for (int i = 0; i < column; i++)
//         {
//             int temp = firstRow[i];
//             firstRow[i] = lastRow[i];
//             lastRow[i] = temp;
//         }
//     for (int i = 0; i < column; i++)
//         {
//             arr[0, i] = firstRow[i];
//             arr[row - 1, i] = lastRow[i];
//         }
// }