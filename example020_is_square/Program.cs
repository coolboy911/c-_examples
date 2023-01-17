//Напишите программу, которая принимает 
// на вход два числа и проверяет, является 
// ли одно число квадратом другого.
Console.Clear();
Console.WriteLine("Введите 2 числа");
int num1 = int.Parse(Console.ReadLine()!);
int num2 = int.Parse(Console.ReadLine()!);
if (num1 * num1 == num2 || num1 == num2 * num2) Console.WriteLine("ДА");
else Console.WriteLine("НЕТ");