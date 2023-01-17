//Напишите программу, которая выводит случайное 
//трехзначное число и удаляет вторую цифру этого числа.
Console.Clear();
int number = new Random().Next(100, 1000);
Console.WriteLine(number);

int number1 = number / 100;  // 792 -> 7
int number3 = number % 10;  // 792 -> 2
int result = number1 * 10 + number3;  // 7*10 + 2 = 72
Console.WriteLine(result);