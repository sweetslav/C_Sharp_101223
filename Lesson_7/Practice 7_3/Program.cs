// Считать строку с консоли, содержащую латинские буквы. Вывести на экран согласные буквы этой строки. Указание: Использовать рекурсию. Не использовать цикл.

void PrintOnlyConsonants(string word, int index = 0)
{
    if (index == word.Length) return;
    if ("bcdfghjklmnpqrstvwxyz ".Contains(char.ToLower(word[index])))
        Console.Write($"{word[index]}");

    PrintOnlyConsonants(word, index + 1);
}

Console.Write("Input text: ");
string text = Console.ReadLine()!;
PrintOnlyConsonants(text);