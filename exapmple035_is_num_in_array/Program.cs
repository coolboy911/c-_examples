// присутствует ли заданное число в массиве
int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void FindNumber(int[] array, int num)
{
    string answer = "Нет";
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num)
        {
            answer = "Да";
            break;
        }
    }
    Console.WriteLine(answer);
}

int[] array = GetRandomArray(8, -9, 9);
Console.WriteLine(string.Join(" ", array));

FindNumber(array, 4); // найти 4