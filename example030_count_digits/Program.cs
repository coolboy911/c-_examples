int CountDigits(int num){
    int count = 0;
    while (num > 0){
        num /= 10;
        count += 1;
    }
    return count;
}

Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
int sum = CountDigits(a);
Console.WriteLine(sum);