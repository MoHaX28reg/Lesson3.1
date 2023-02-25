// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.Clear();

string CountNumber(int n)
{
    if (n == 1) return n.ToString();
    else { return n.ToString() + ", " + CountNumber(n - 1); }

}

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(CountNumber(n));
