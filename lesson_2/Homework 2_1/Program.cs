// Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23.

int n = int.Parse(Console.ReadLine()!);
int a = 7;
int b = 23;

if (n % a == 0 && n % b == 0)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}