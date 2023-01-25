// Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] RandomBinArray(int digits)
{
    int[] array = new int[digits];
    for (int i = 0; i < digits; i++)
    {
        array[i] = new Random().Next(0,2);
    }
    return array;
}

Console.WriteLine("Введите колличество чисел массива: ");
int a = int.Parse(Console.ReadLine()!);
int[] x = RandomBinArray(a);
Console.WriteLine(string.Join(" ", x));