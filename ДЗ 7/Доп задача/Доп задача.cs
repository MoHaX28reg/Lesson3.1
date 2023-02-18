// See https://aka.ms/new-console-template for more information
Console.Clear();

string Replace(string text)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        var I = 1;
        var IV = 4;
        var V = 5;
        var IX = 9;
        var X = 10;
        var XL = 40;
        var L = 50;
        var XC = 90;
        var C = 100;
        var CD = 400;
        var D = 500;
        var CM = 900;
        var M = 1000;
    }

    return result;
}

Console.Write("Введите римское число: ");
string text = Convert.ToString(Console.ReadLine());

string newText = Replace(text);
Console.WriteLine(newText);
