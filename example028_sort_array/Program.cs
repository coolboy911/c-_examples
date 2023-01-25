int[] CreateRandomArray(int lenght){
    int[] RandomArray = new int[lenght];
    for (int i = 0; i < lenght; i++){
        RandomArray[i] = new Random().Next(1, 100);
    }
    return RandomArray;
}

void PrintArray(int[] array){
    for (int i = 0; i < array.Length; i++){
        Console.Write($"{array[i]} ");
    }
}

void SortArray(int[] array){
    for (int i = 0; i < (array.Length - 1); i++){
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++){
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int temp = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temp;
        
    }
}

int[] RandomArray = CreateRandomArray(lenght: 20);
PrintArray(RandomArray);
Console.WriteLine();
SortArray(RandomArray);
PrintArray(RandomArray);
Console.WriteLine();
