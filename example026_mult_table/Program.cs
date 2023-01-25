//https://learn.microsoft.com/ru-ru/dotnet/api/system.string.format?view=net-7.0 formatting
for (int i = 1; i <= 10; i++)
{
    for (int j = 1; j <= 10; j++)
    {
        Console.Write("{0,-3} ", i * j);
    }
    Console.WriteLine("");
}