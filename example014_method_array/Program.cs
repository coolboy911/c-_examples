int[] array = { 14, 92, 32, 47, 52, 56, 47, 81, 39 };

int n = array.Length;
int find = 47;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}