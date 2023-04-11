// Задача №44
// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

//Ввод данных
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

//метод Фибоначчи
string FibNum(int num)
{
    string res = "0, 1";
    long first = 0;
    long last = 1;
    for (int i = 2; i < num; i++)
    {
        res = res + ", " + (first + last);
        // first = last;
        // last = last+first;
        (first, last) = (last, last + first);
    }

    return res;
}

int num = ReadData("Введите число: ");
string res = "";
res = FibNum(num);
Console.WriteLine(res);













