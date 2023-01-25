// Вид 1 не принимают, не возвращают
void Method1(){
    Console.WriteLine("Автору 5 лет");
}
Method1();

// Вид 2 принимают, не возвращают
void Method2(string msg){
    Console.WriteLine(msg);
}
Method2(msg: "Текст сообщения");

void Method21(string msg, int count){
    int i = 0;
    while (i < count){
        Console.WriteLine(msg);
        i++;
    }
}
Method21(count: 4, msg: "Текст");  //при явном обозначении не обязательно писать по порядку

// Вид 3 не принимают, возвращают
int Method3(){
    return new Random().Next(1,10);
}

int rand = Method3();
Console.WriteLine(rand);

// Вид 4 принимают, возвращают
// string Method4(int count, string c){
//     string result = string.Empty;
//     int i = 0;
//     while (i < count){
//         result += c;
//         i++;
//     }
//     return result;
// }
string Method4(int count, string c){
    string result = string.Empty;
    for (int i = 0; i < count; i++){
        result += c;
    }
    return result;
}

string res = Method4(10, "asdf");
Console.WriteLine(res);