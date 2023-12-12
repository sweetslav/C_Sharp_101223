// Замените отирцательные элементы на положительные и наоборот

internal class Program
{
    private static void Main(string[] args)
    {
        int[] MassNums(int size, int from, int to)
        {
            int[] arr = new int[size];

            for (int i = 0; i < size; i++)
            {
                arr[i] = new Random().Next(from, to + 1);
            }
            return arr;
        }
        void Print(int[] arr)
        {
            int size = arr.Length;
            for (int i = 0; i < size; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
        }

        void ChangeValue(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = -arr[i];
            }
        }

        int num = int.Parse(Console.ReadLine()!);
        int start = int.Parse(Console.ReadLine()!);
        int stop = int.Parse(Console.ReadLine()!);

        int[] mass = MassNums(num, start, stop);
        Print(mass);
        ChangeValue(mass);
        Print(mass);

    }
}