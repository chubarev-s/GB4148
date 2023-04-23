// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29



//Ввод данных
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

//Метод формирования функции Аккермана:
long AckermanFunction(long m, long n)
{
    while(m!=0)
    {
        if(n==0)
        {
            n++;
        }
        else
        {
            n = AckermanFunction(m, n - 1);
        }
        m--; 
    }
    return n+1;
}

long M = ReadData("Введите число M: ");
long N = ReadData("Введите число N: ");
if(M<0||N<0)
{
    Console.WriteLine("Введите положительные целые числа!");
}
else
{
    long MN = AckermanFunction(M, N);
    Console.WriteLine($"Значение функции Аккермана: {MN}");
}









