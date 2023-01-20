Console.Clear();

Console.Write("Введите x1: ");
int x1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите y1: ");
int y1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите x2: ");
int x2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите y2: ");
int y2 = int.Parse(Console.ReadLine()!);

double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
result = Math.Round(result, 2);
Console.WriteLine(result);