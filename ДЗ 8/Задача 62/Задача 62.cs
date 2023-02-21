// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Console.Clear();

int[,] GetArray2D(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = 0;
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

void GetNewArray2D(int[,] inArray, int m, int n, int count)
{
    int mFirst = 0;
    int nFirst = 0;
    int mLast = 0;
    int nLast = 0;
    while (count <= inArray.GetLength(0) * inArray.GetLength(1))
    {
        inArray[m, n] = count;
        if (m == mFirst && n < inArray.GetLength(1) - nLast - 1)
            n++;
        else if (n == inArray.GetLength(1) - nLast - 1 && m < inArray.GetLength(0) - mLast - 1)
            m++;
        else if (m == inArray.GetLength(0) - mLast - 1 && n > nFirst)
            n--;
        else
            m--;
        if (m == mFirst + 1 && n == nFirst && nFirst != inArray.GetLength(1) - nLast - 1)
        {
            mFirst++;
            nFirst++;
            mLast++;
            nLast++;
        }
        count++;
    }
}

Console.Write("Введите кол-во строк: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов: ");
int col = int.Parse(Console.ReadLine()!);

int[,] array2D = GetArray2D(row, col);

GetNewArray2D(array2D, 0, 0, 1);
PrintArray(array2D);



