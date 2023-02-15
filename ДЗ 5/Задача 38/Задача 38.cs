// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
Console.Clear();

double[] GetArrayDoub(int size, double minValue, double maxValue)
{
    double[] result = new double[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = Math.Round(new Random().NextDouble() * (maxValue - minValue) + minValue, 2);
    }
    return result;
}

double DiffOfNum(double[] array)
{
    double maxValue = array[0];
    double minValue = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (maxValue < array[i])
            maxValue = array[i];
        if (minValue > array[i])
            minValue = array[i];
    }
    double diff = maxValue - minValue;
    return diff;
}    

double[] array = GetArrayDoub(6, -10, 10);
Console.WriteLine(String.Join(", ", array));
Console.WriteLine(DiffOfNum(array));