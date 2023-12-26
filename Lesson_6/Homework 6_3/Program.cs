// Задайте произвольную строку. Выясните, является ли она палиндромом.

bool IsPalindrome(string text) // Мeтод проверяет является ли введенный текст паллиндромом
{
    int left = 0;
    int right = text.Length - 1;

    while (left < right)
    {
        if (char.ToLowerInvariant(text[left]) != char.ToLowerInvariant(text[right]))
        {
            return false;
        }

        left++;
        right--;
    }

    return true;
}

Console.WriteLine("Input text: ");
string text = Console.ReadLine()!;

bool result = IsPalindrome(text);
Console.WriteLine(result);

// string RemoveNonAlphanumeric(string text) // Удаление всех символов, кроме букв и цифр
// {
//     string cleanedText = "";
//     foreach (char c in text)
//     {
//         if (char.IsLetterOrDigit(c))
//         {
//             cleanedText += c;
//         }
//     }
//     return cleanedText;
// }