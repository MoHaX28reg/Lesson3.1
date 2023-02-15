// Задача "со звездочкой": Разобраться с алгоритмом сортировки методом пузырька. Реализовать невозрастающую сторировку.
Console.Clear();

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

int[] BubleMeth(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length - 1; j++)
        {
            if (array[j] < array[j + 1])
            {
                int temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
            }
        }
    }
    return array;
}

int[] arr = GetArray(5, -3, 3);
Console.WriteLine(String.Join(", ", arr));

Console.WriteLine(String.Join(", ", BubleMeth(arr)));