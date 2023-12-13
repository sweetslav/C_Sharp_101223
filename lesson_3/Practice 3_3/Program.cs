using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] MassNums(int size, int from, int to) // Создаем массив и заполняем его
        {
            int[] arr = new int[size];

            for (int i = 0; i < size; i++)
            {
                arr[i] = new Random().Next(from, to + 1);
            }
            return arr;
        }

        void Print(int[] arr) // Выводим массив на экран
        {
            int size = arr.Length;
            for (int i = 0; i < size; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
        }

        int[] PairNum(int[] arr) // Умножаем элементы
        {
            int size = arr.Length;
            int flex_size = size / 2 + size % 2;
            int[] new_arr = new int[flex_size];

            for (int i = 0; i < size / 2; i++)
            {
                new_arr[i] = arr[i] * arr[size - i - 1];
            }
            if (size % 2 == 1)
                new_arr[flex_size - 1] = arr[size / 2];

            return new_arr; // Возвращаем новый массив
        }

        int num = int.Parse(Console.ReadLine()!);
        int start = int.Parse(Console.ReadLine()!);
        int stop = int.Parse(Console.ReadLine()!);

        int[] mass = MassNums(num, start, stop);
        Print(mass);
        int[] new_mass = PairNum(mass);
        Print(new_mass);
    }
}
