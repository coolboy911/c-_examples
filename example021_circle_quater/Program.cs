﻿Console.Write("Введите номер четверти: ");
int quater = int.Parse(Console.ReadLine()!);
// if (quater == 1) Console.WriteLine("x > 0 ; y > 0");
// if (quater == 2) Console.WriteLine("x < 0 ; y > 0");
// if (quater == 3) Console.WriteLine("x < 0 ; y < 0");
// if (quater == 4) Console.WriteLine("x > 0 ; y < 0");
if (quater == 1 || quater == 2) Console.Write("y > 0: ");
else Console.Write("y < 0: ");
if (quater == 1 || quater == 4) Console.Write("x > 0 ");
else Console.Write("x < 0");
Console.WriteLine("");