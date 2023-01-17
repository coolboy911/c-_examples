int number = new Random().Next(10,100);
Console.WriteLine(number);
int number1 = number / 10;
int number2 = number % 10;
if (number1 > number2) Console.WriteLine(number1);
else Console.WriteLine(number2);