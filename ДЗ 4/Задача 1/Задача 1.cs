// Подсчитать сумму цифр в числе
Console.Clear();

Console.Write("Введите число: "); 
int a = Convert.ToInt32(Console.ReadLine()!);

int sum = 0;

while (a != 0)
{
    sum = sum + (a % 10);
    a = a / 10;
}
Console.WriteLine($"Сумма цифр в числе равна {sum}");