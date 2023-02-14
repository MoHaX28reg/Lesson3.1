//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
Console.Clear();

int[] EnterData()
{
    int[] array = new int[4];
    Console.Write("Введите индекс переменной Х первой прямой: ");
    array[0] = int.Parse(Console.ReadLine()!);
    Console.Write("Введите свободный индекс первой прямой: ");
    array[1] = int.Parse(Console.ReadLine()!);
    Console.Write("Введите индекс переменной Х второй прямой: ");
    array[2] = int.Parse(Console.ReadLine()!);
    Console.Write("Введите свободный индекс второй прямой: ");
    array[3] = int.Parse(Console.ReadLine()!);
    return array;
}

void FindPoint(int[] array)
{
    double k1 = array[0];
    double b1 = array[1];
    double k2 = array[2];
    double b2 = array[3];
    if (k1 == k2 && b1 == b2)
        Console.WriteLine("Линии накладываются одна на другую, точек пересечения бесконечное множество");
    else
    {
        if (k1 == k2)
            Console.WriteLine("Линии паралельны, точки пересечения нет");
        else
        {
            double x = -(b1 - b2) / (k1 - k2);
            double y = k1 * x + b1;
            double[] point = new double[2];
            point[0] = Math.Round(x, 1);
            point[1] = Math.Round(y, 1);
            Console.WriteLine($"Точка пересечения ({String.Join(", ", point)})");
        }
    }
}

int[] arr = EnterData();
FindPoint(arr);

