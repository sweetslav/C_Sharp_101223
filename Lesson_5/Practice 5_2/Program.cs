//  Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали
//  (с индексами (0,0); (1,1); (2,2))

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

int SumDiagonal(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    int diagSum = 0;

    for (int i = 0; i < row; i ++)
        for (int j = 0; j < column; j ++)
            if (i == j)
                diagSum += arr[i, j];
    return diagSum;
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
int result = SumDiagonal(mass);
Console.WriteLine(result);

