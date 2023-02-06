// Написать программу вычисления произведения чисел от 1 до N
Console.Clear();

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()!);

int count = 0;
int prod = 1;

if (n >= 0)
{
    while (n > count)
    {
        count += 1;
        prod = prod * count;
    }
}
else
{
    while (n < count)
    {
        count -= 1;
        prod = prod * count;
    }
}

Console.WriteLine($"{n}! равен {prod}");