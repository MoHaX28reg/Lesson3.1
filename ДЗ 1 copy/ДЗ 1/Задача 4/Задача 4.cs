// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Clear();

Console.Write("Ввести первое число ");
int n1 = int.Parse(Console.ReadLine()!);

Console.Write("Ввести второе число ");
int n2 = int.Parse(Console.ReadLine()!);

Console.Write("Ввести третье число ");
int n3 = int.Parse(Console.ReadLine()!);

int max = n1;

if (max > n2 && max > n3) {} 
else 
{
    if (n2 > n3) 
    {
        max = n2;
    }
    else {max = n3;}
}
Console.Write($"Максимальное число {max}");