// Задача №42
// Напишите программу, которая будет преобразовывать десятичное число в двоичное.

//Ввод данных
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

//метод преобразования числа
string DecToBin(int num)
{
    string res = String.Empty;
    while(num>0)
    {
        res = res + num % 2;
        num = num/2;
    }
    return res;
}

string res = "";
int a = ReadData("Введите число: ");
res = DecToBin(a);
Console.WriteLine(res);
Console.WriteLine("----------------------------------------------------------------------");
Console.WriteLine(Convert.ToString(a, 2));
Console.WriteLine(Convert.ToString(a, 8));
Console.WriteLine(Convert.ToString(a, 16));