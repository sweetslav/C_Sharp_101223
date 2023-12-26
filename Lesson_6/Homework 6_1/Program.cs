// Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива. 

char[,] charArray = {
    {'H','e','l','l','o'},
    { 'W','o','r','l','d'}
};

string charArrayToString(char[,] arr) // Метод ковертирует двумерный массив в строку
{
    int rows = arr.GetLength(0);
    int columns = arr.GetLength(1);

    string result = "";

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result += arr[i, j];
            if (j == columns - 1) // Добавил пробел между словами
            {
                result += " ";
            }
        }
    }
    Console.Write(" ");
    return result;
}
string res = charArrayToString(charArray);
Console.Write(res);