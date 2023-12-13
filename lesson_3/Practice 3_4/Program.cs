// создать массив из числа и развернуть его

internal class Program
{
    private static void Main(string[] args)
    {
        int[] MassNums(int num)
        {
            int[] arr = new int[3];

            for (int i = 0; i < 3; i++)
            {
                arr[i] = num % 10;
                num /=10;
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

        int number = new Random().Next(100, 1000);
        Console.WriteLine(number);
        int[] mass = MassNums(number);
        Print(mass);        
        
    }
}

