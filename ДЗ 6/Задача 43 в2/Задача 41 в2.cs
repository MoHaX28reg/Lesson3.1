// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.Clear();

void UserNum()
{
    Console.Write($"Введите количество задаваемых чисел: ");
}

int ComparAnalys(int N)
{
    int[] array = new int[N];
    int count = 0;
    for (int i = 0; i < N; i++)
    {
        Console.Write($"Введите {i + 1} число: ");
        array[i] = int.Parse(Console.ReadLine()!);
        if (array[i] > 0)
            count++;
    }
    return count;
}

UserNum();
int n = int.Parse(Console.ReadLine()!);
int countArray = ComparAnalys(n);
Console.WriteLine($"Количество заданных значений больше 0: {countArray}");