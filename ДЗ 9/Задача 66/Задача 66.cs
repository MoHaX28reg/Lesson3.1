// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Clear();

int CountNumber(int n, int m)
{
    if (n == m) return m;
    else { return n + CountNumber(n + 1, m); }
}

Console.Write("Введите первое число: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int m = int.Parse(Console.ReadLine()!);

Console.WriteLine(CountNumber(n, m));
