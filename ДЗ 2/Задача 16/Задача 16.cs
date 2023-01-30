// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Clear();
Console.Write("Введите номер дня недели от 1 до 7: ");

int n = int.Parse(Console.ReadLine()!);

if (n > 7 || n < 1) { Console.Write("С таким номером дня недели нет"); }
else
{
    if (n == 6 || n == 7) { Console.WriteLine($"{n}-> выходной"); }
    else 
    { Console.WriteLine($"{n} -> не выходной"); }
}

