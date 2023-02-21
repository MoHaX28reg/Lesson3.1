// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
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

int[] SumInRol(int[,] inArray, int n)
{
    int[] array1D = new int[n];
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        int sumRol = 0;
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            sumRol += inArray[i, j];
        }
        array1D[i] = sumRol;
    }
    return array1D;
}

void SearchMinSumInRol(int[] inArray)
{
    int min = inArray[0];
    int rol = 1;
    for (int i = 1; i < inArray.Length; i++)
    {
        if (inArray[i] < min)
        {
            min = inArray[i];
            rol = i + 1;
        }
    }
    Console.WriteLine($"В {rol} строке сумма элементов минимальна");
}

Console.Write("Введите кол-во строк: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов: ");
int col = int.Parse(Console.ReadLine()!);

int[,] array2D = GetArray(row, col, 0, 10);
PrintArray(array2D);

int[] array1D = SumInRol(array2D, col);
SearchMinSumInRol(array1D);