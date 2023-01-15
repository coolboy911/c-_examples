Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine()!);
int LastDigit = number % 10;
Console.WriteLine($"последняя цифра числа: {LastDigit}");