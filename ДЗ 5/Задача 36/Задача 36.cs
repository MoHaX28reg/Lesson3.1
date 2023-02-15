// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
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

int CountNumber(int[] array)
{
    int size = array.Length;
    int sum = 0;
    for (int i = 0; i < size; i+=2)
    {
        sum = sum + array[i];
    }
    return sum;
}

int[] array = GetArray(5, 1, 10);
Console.WriteLine(String.Join(", ", array));
int count = CountNumber(array);

Console.WriteLine(count);