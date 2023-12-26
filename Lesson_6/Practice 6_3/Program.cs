// Считать строку с консоли, состоящую из латинских букв в нижнем регистре. Выяснить, сколько среди введённых букв гласных.

int CountVowels(string word) // Метод считает количество гласных букв в тексте
{
    char[] vowels = {'a', 'e', 'i', 'o', 'u', 'y'};
    int count = 0;

    foreach (var item in word)
    {
        if (Array.IndexOf(vowels, item) != -1) 
        {
            count++;
        }
    }

    return count;
}

Console.Write("Input text: ");
string text = Console.ReadLine()!;

int res = CountVowels(text);
Console.WriteLine(res);
