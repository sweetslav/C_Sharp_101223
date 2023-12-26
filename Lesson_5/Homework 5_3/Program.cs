// Задача 3: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] MassNums(int row, int column, int from, int to) // Метод создает двумерный массив
{
    int[,] arr = new int[row, column];
    Random random = new Random();

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = random.Next(from, to + 1);

    return arr;
}

void Print(int[,] arr) // Метод выводит на экран двумерный массив
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

int FindRowWithSumMininum(int[,] arr) // Метод находит индекс строки с наименьшей суммой
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    int minSum = int.MaxValue;
    int minSumRowIndex = -1;

    for (int i = 0; i < row; i++)
    {
        int rowSum = 0;
        for (int j = 0; j < column; j++)
        {
            rowSum += arr[i, j];
        }

        if (rowSum < minSum)
        {
            minSum = rowSum;
            minSumRowIndex = i;
        }
    }
    return minSumRowIndex;
}

int CalculateRowSum(int[,] arr, int rowIndex) // Метод вычисляет сумму элементов в строке
{
    int column = arr.GetLength(1);
    int rowSum = 0;

    for (int j = 0; j < column; j++)
    {
        rowSum += arr[rowIndex, j];
    }

    return rowSum;
}

int[] SumNum(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    int[] all_nums = new int[row];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            all_nums[i] += arr[i, j];
        }
    }
    return all_nums;
}

// void FindMin(int[] arr)
// {
//     int min_ind = 0;

//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] < arr[min_ind] min_ind =i)
//     }
// }

Console.Write("Enter the number of rows: "); // Вводим число строк
int row_num = int.Parse(Console.ReadLine()!);

Console.Write("Enter the number of columns: "); // Вводим число столбцов
int column_num = int.Parse(Console.ReadLine()!);

Console.Write("Enter the min number of array: "); // Вводим минимальное число в массиве
int start = int.Parse(Console.ReadLine()!);

Console.Write("Enter the max number of array: "); // Вводим максимальное число в массиве
int stop = int.Parse(Console.ReadLine()!);
Console.WriteLine();

int[,] mass = MassNums(row_num, column_num, start, stop);

Print(mass);

int minSumRowIndex = FindRowWithSumMininum(mass);
Console.WriteLine($"Row with the smallest sum of elements is row {minSumRowIndex + 1}");
Console.WriteLine("(numeration starts with 1)");
Console.WriteLine();

int rowSum = CalculateRowSum(mass, minSumRowIndex);
Console.WriteLine($"Sum of elements in row {minSumRowIndex}: {rowSum}"); // Выводим сумму элементов
Console.WriteLine();

