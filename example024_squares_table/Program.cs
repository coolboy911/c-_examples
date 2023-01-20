Console.Write("Введите N: ");
int N = int.Parse(Console.ReadLine()!);
int count = 1;
while (count <= N)
{
    Console.Write(Math.Pow(count, 2));
    if (count < N) Console.Write(", ");
    count++;
}
Console.WriteLine("");