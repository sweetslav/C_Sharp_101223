// Напишите программу, которая принимает на вход случайное целое число из отрезка 10 - 99
// и показывает наибольшую цифру этого числа

Random rnd = new Random();
int randomNumber = rnd.Next(10, 100); // Генерируем случайное число от 10 до 99

Console.WriteLine("Случайное число из отрезка 10-99: " + randomNumber);

int firstDigit = randomNumber / 10;
int secondDigit = randomNumber % 10;

if (firstDigit > secondDigit)
    {
        Console.WriteLine(firstDigit);
    } 
else if (secondDigit > firstDigit)
    {
        Console.WriteLine(secondDigit);
    }