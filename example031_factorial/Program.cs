int Mult(int arg)
{
    int x = 1;
    for (int i = 1; i <= arg; i++)
    {
        x *= i;
    }
    return x;
}

Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
int total = Mult(a);
Console.WriteLine(total);