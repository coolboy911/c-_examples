Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine()!);

int sumFunc(int arg){
    int sum = 0;
    for (int i = 1; i <= arg; i++){
        sum += i;
    }
    return sum;
}

int sum = sumFunc(a);
Console.WriteLine(sum);