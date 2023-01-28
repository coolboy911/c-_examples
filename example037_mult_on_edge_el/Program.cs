// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний 
// и т.д. Результат запишите в новом массиве. 
// [1 2 3 4 5] -> 5 8 3 [6 7 3 6] -> 36 21

Console.Clear();
int[] GetRandomArray (int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size ; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

int[] MultipleArray (int[] array)
{
    int[] newArray = new int[array.Length / 2 + array.Length % 2];
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = array[i] * array[array.Length - i - 1];
    }
    if (array.Length % 2 == 1)
    {
        newArray[array.Length / 2] = array[array.Length / 2];
    }
    return newArray;
}

int[] array = GetRandomArray(5, 1, 9);
Console.WriteLine(string.Join(" ", array));
int[] newArray = MultipleArray(array);
Console.WriteLine(string.Join(" ", newArray));

