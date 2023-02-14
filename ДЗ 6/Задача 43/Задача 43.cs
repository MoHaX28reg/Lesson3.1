// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.Clear();

void UserNum()
{
    Console.Write($"Введите количество задаваемых чисел ");
}

int[] AddArray(int N)
{
    int[] array = new int[N];
    for (int i = 0; i < N; i++)
    {
        Console.Write($"Введите {i + 1} число ");
        array[i] = int.Parse(Console.ReadLine());
    }
    return array;
}

int ComparAnalys(int[] inArray)
{
    int count = 0;
    for (int i = 0; i < inArray.Length; i++)
    {
        if (inArray[i] > 0)
            count++;
    }
    return count;
}

UserNum();
int n = int.Parse(Console.ReadLine());
int[] arr = AddArray(n);
Console.WriteLine(String.Join(", ", arr));
int countArray = ComparAnalys(arr);
Console.WriteLine($"Количество заданных значений больше 0: {countArray}");