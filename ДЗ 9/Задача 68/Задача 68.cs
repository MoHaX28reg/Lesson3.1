// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. 
Console.Clear();

int AkkermanFunction(int n, int m)
{
    if (n == 0) return m + 1;
    else if (m == 0) return AkkermanFunction(n - 1, 1); 
    else return AkkermanFunction(n - 1, AkkermanFunction(n, m-1));
}

Console.Write("Введите первое число: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int m = int.Parse(Console.ReadLine()!);

Console.WriteLine(AkkermanFunction(n, m));
