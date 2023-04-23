// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

//Ввод данных
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

//Рекур.метод
int RecMN(int m, int n)
{

    if (m < n)
    {
        return m = m + RecMN(m + 1, n);
    }
    else
    {
        return m;
    }
}

int M = ReadData("Введите число M: ");
int N = ReadData("Введите число N: ");
int MN = (M > N) ? RecMN(N, M) : RecMN(M, N);
Console.Write(MN);
