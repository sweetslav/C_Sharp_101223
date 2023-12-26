// На основе символов строки (тип string) сформировать массив символов (тип char[]). Вывести массив на экран. Указание Метод строки ToCharArray() не использовать.

char[] StrToChArr(string word) // Метод преобразует строку в символы
{
    int len = word.Length;
    char[] result = new char[len];

    for (int i = 0; i < len; i++)
        result[i] = word[i];
    
    return result;
}

string hi = "Hello";
char[] charArr = StrToChArr(hi);

foreach (var item in charArr)
{
    Console.Write(item + ", ");
}
