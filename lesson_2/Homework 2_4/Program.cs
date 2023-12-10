// Напишите программу, которая на вход принимает случайное число, а на выходе
// показывает его цифры через запятую

Random rnd = new Random();
int randomNumber = rnd.Next(1, 100000); // Генерируем случайное число от 1 до 99999
Console.WriteLine(randomNumber);

string finalString = "";

while (randomNumber != 0)
    {
    int lastDigit = randomNumber % 10;
    finalString = lastDigit + ", " + finalString;
    randomNumber /= 10;
    }

Console.WriteLine(finalString);