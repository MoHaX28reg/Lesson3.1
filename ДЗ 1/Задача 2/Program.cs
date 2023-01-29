// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Clear();

Console.Write("Ввести первое число ");
int n1 = int.Parse(Console.ReadLine()!);

Console.Write("Ввести второе число ");
int n2 = int.Parse(Console.ReadLine()!);

int max = n1;

if (max > n2); 
else max = n2;

Console.Write($"Максимальное число {max}");