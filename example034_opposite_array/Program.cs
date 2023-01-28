// Замените положительные элементы 
// массива на отрицательные и наоборот

int[] GetRandomArray (int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size ; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void OppositeArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = -array[i];
    }
}

int[] array = GetRandomArray(4, -9, 9);
Console.WriteLine(string.Join(" ", array));

OppositeArray(array);
Console.WriteLine(string.Join(" ", array));
