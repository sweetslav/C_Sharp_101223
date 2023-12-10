// Напишите программу, которая принимает на вход координаты точки X и Y != 0 
// и выдает номер координатной четверти плоскеости, в которой она находится
// Нумерация начинается справа сверху и идет против часовой стрелки

Console.WriteLine("Enter X:");
int x = int.Parse(Console.ReadLine()!);

Console.WriteLine("Enter Y:");
int y = int.Parse(Console.ReadLine()!);

if (x > 0 && y > 0)
{
    Console.WriteLine("1st quarter");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("2nd quarter");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("3rd quarter");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("4th quarter");
}
