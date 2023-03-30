// Задача №22
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

//метод ввода числа
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

//метод создания строки таблицы
string LineGen(int num, int pow)   //т.к. выдаём строку, то используем string
{
    string res = string.Empty; //альт запись string res = ""; 
    for (int i = 1; i <= num; i++)
    {
        res += Math.Pow(i, pow) + " ";
    }
    return res;
}

int numN = ReadData("Введите число: ");
Console.WriteLine(LineGen(numN, 1));
Console.WriteLine(LineGen(numN, 2));
