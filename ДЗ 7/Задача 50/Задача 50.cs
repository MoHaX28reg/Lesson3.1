// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Clear();

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

void ElementSearch(int n, int m, int[,] array)
{
    if (n <= 0 || n > array.GetLength(0) || m <= 0 || m > array.GetLength(1))
        Console.WriteLine("такого числа в массиве нет");
    else
    {
        Console.WriteLine(array[n - 1, m - 1]);
    }
}

Console.Write("Введите номер сторки: ");
int n = int.Parse(Console.ReadLine()!);

Console.Write("Введите номер столбца: ");
int m = int.Parse(Console.ReadLine()!);

int[,] arr = GetArray(4, 5, 0, 10);
PrintArray(arr);
ElementSearch(n, m, arr);
