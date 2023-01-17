void FillArray(int[] array)
{
    int lenght = array.Length;
    int index = 0;
    while (index < lenght)
    {
        array[index] = new Random().Next(1, 100);
        index++;
    }
}

void PrintArray(int[] array)
{
    int lenght = array.Length;
    int position = 0;
    while (position < lenght)
    {
        Console.Write($"{array[position]} ");
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int lenght = collection.Length;
    int index = 0;
    int position = -1;
    while (index < lenght)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] RandomArray = new int[10];
Console.WriteLine("hello");
FillArray(RandomArray);
// RandomArray[4] = 4;
PrintArray(RandomArray);

Console.WriteLine();
int pos = IndexOf(RandomArray, 4);
Console.WriteLine(pos);