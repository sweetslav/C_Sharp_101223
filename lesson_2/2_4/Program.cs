// Напишите программу, которая выводит третьью с конца цифру заданного числа
// Или сообщает, что третьей цифры нет.

Console.WriteLine("Enter a number:");
int num = int.Parse(Console.ReadLine()!);

int count = 0;
int thirdFromEnd = 0;

while (num != 0)
    {
        count++; // Увеличиваем счетчик разрядов числа
        if (count == 3)
            {
                thirdFromEnd = num % 10; // Записываем третью с конца цифру числа
            }
        num /= 10; // Уменьшаем число, удаляя последнюю цифру
    }

if (count < 3)
    {
    Console.WriteLine("There is no third digit");
    }
else
    {
    Console.WriteLine("The third digit from the end is: " + thirdFromEnd);  
    }