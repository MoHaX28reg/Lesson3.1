// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Clear();

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine()!);

int b = 1;

while (b <= a)
{
    Console.Write($"{Math.Pow(b, 3)} ");
    b ++;
}