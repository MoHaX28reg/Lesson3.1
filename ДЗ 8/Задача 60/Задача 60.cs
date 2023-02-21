// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Console.Clear();

int[,,] GetArray(int m, int n, int l)
{
    int firstNumber = 10;
    int[,,] result = new int[m, n, l];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < l; k++)
            {
                result[i, j, k] = firstNumber + 3;
                firstNumber = result[i, j, k];
            }
        }
    }
    return result;
}
void PrintArray(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(2); k++)
            {
                Console.Write($"{inArray[i, j, k]}\t ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

void ShowElenentAndIndex(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(1); i++)
    {
        for (int j = 0; j < inArray.GetLength(2); j++)
        {
            for (int k = 0; k < inArray.GetLength(0); k++)
            {
                Console.WriteLine($"{inArray[i, j, k]}({i},{j},{k})\t ");
            }

        }

    }
}

Console.WriteLine();
int[,,] array3D = GetArray(2, 2, 2);
PrintArray(array3D);
ShowElenentAndIndex(array3D);
