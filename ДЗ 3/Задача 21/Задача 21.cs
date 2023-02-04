//Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.Clear();

Console.Write("Введите координату X точки А: ");
int xa = Convert.ToInt32(Console.ReadLine()!);

Console.Write("Введите координату Y точки А: ");
int ya = Convert.ToInt32(Console.ReadLine()!);

Console.Write("Введите координату Z точки А: ");
int za = Convert.ToInt32(Console.ReadLine()!);

Console.Write("Введите координату X точки B: ");
int xb = Convert.ToInt32(Console.ReadLine()!);

Console.Write("Введите координату Y точки B: ");
int yb = Convert.ToInt32(Console.ReadLine()!);

Console.Write("Введите координату Z точки B: ");
int zb = Convert.ToInt32(Console.ReadLine()!);

double x = Math.Pow((xa - xb), 2);
double y = Math.Pow((ya - yb), 2);
double z = Math.Pow((za - zb), 2);

double ab = Math.Sqrt((x + y + z));

Console.WriteLine($"{ab:f2}");
