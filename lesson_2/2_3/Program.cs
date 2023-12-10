//Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
//Если второе число некратно первому, то программа выводит остатоек от деления.

int n1 = int.Parse(Console.ReadLine()!);
int n2 = int.Parse(Console.ReadLine()!);
int n3 = n1 % n2;
if (n3 == 0) 
    Console.WriteLine("Да");    
else 
    Console.WriteLine("Нет, " + n3);
