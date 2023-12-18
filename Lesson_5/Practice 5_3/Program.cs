// Задайте двумерный массив из целых чисел
//  Сформируйте новый массив, состоящий из средних арифметических значений по строкам двумерного массива

void Print(int[,] arr)
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

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to + 1);
    return arr;
}

void ArithMean(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    double res;

    for (int i = 0; i < row; i ++)
        {
            res = 0;
        for (int j = 0; j < column; j ++)
            res += arr[i, j];
        Console.Write($"{Math.Round(res/column, 2)}; ");
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

int[,] mass = MassNums(row_num, column_num, start, stop);

Print(mass);
ArithMean(mass);

