// Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между максимальным и минимальным элементов массива.

double[] floatingArray = { 1.5, 2.8, 3.1, 5.6, 4.2, 7.9 };
double min = floatingArray[0];
double max = floatingArray[0];

for (int i = 1; i < floatingArray.Length; i++)
{
    if (floatingArray[i] < min)
    {
        min = floatingArray[i];
    }
    if (floatingArray[i] > max)
    {
        max = floatingArray[i];
    }
}

double difference = max - min;
Console.WriteLine($"Разница между максимальным и минимальным элементами: {difference}");
