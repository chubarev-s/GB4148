//  ---------------------------------------------------------------------
//                                 Задача 65
//  Задайте значения M и N. Напишите программу, которая найдёт 
// все натуральные элементы в промежутке от M до N.
// ---------------------------------------------------------------------

//Ввод данных
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

//Рекур.метод
string RecMN(int m, int n)
{

    if(m<n)
    {
        return m+" "+RecMN(m+1,n);
    }
    else
    {
        return String.Empty;
    }
}

int M = ReadData("Введите число M: ");
int N = ReadData("Введите число N: ");
// if (M > N)
// {
//     int buf = M;
//     M = N;
//     N = buf;
// }
//string MN = RecMN((M>N)?N:M, (M>N)?M:N);
string MN = (M>N)?RecMN(N,M):RecMN(M,N); 
Console.Write(MN);
