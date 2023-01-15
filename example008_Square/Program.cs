Console.Write("Введите число: ");
int numberA = int.Parse(Console.ReadLine()!);

int squareA = numberA * numberA;
Console.WriteLine($"Квадрат числа {numberA} равен {squareA}");

int squareB = Convert.ToInt32(Math.Pow(numberA, 2));
Console.WriteLine($"Квадрат числа {numberA} равен {squareB}");