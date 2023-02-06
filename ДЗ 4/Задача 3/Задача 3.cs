// Показать кубы чисел, заканчивающихся на четную цифру
Console.Clear();

Console.Write("Введите число, до которого необходимо проверять условие задача: ");
int a = Convert.ToInt32(Console.ReadLine()!);

int count = 0;

if (a >= 0)
{
    while (count <= a)
    {
        if (Math.Pow(count, 3) % 2 == 0)
        {
            Console.WriteLine($"{count} в кубе равно {Math.Pow(count, 3)}");
            count++;
        }
        else
            count++;
    }
}
else
{
     while (count >= a)
    {
        if (Math.Pow(count, 3) % 2 == 0)
        {
            Console.WriteLine($"{count} в кубе равно {Math.Pow(count, 3)}");
            count--;
        }
        else
            count--;
    }
} 
