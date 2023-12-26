// Задайте строку, содержащую латинские буквы в обоих регистрах. Сформируйте строку, в которой все заглавные буквы заменены на строчные.

string ToLowerCaseString(string text) // Метод понижает регистр у введенного текста
{
    string result = "";
    foreach (var item in text)
    {
        if (char.IsUpper(item))
        {
            result += char.ToLower(item);
        }
        else
        {
            result += item;
        }
    }
    return result;
}

Console.WriteLine("Input text: ");
string sourseString = Console.ReadLine()!;

string res = ToLowerCaseString(sourseString);
Console.WriteLine(res);
