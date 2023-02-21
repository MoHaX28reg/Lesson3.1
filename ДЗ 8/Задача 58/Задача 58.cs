// See https://aka.ms/new-console-template for more information
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

int[,] MultiMatrix(int[,] array1, int[,] array2)
{
    int[,] multiArray = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int k = 0; k < array2.GetLength(0); k++)
            {
                multiArray[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }
    return multiArray;
}

Console.Write("Введите кол-во строк первой матрицы: ");
int row1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов первой матрицы: ");
int col1 = int.Parse(Console.ReadLine()!);

int[,] array2D1 = GetArray(row1, col1, 0, 4);
PrintArray(array2D1);

Console.WriteLine();

Console.Write("Введите кол-во строк второй матрицы: ");
int row2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов второй матрицы: ");
int col2 = int.Parse(Console.ReadLine()!);

int[,] array2D2 = GetArray(row2, col2, 0, 4);
PrintArray(array2D2);

Console.WriteLine();

if (col1 != row2)
    Console.WriteLine("Произведение матриц не возможно");
else
{
    PrintArray(MultiMatrix(array2D1, array2D2));
}



