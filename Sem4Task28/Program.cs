// Задача №28 (ДОДЕЛАТЬ!!!)
// Напишите программу, которая принимает на вход
// число N и выдаёт произведение чисел от 1 до N.


 using System.Numerics;

//Read data
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}
//Translate res
void PrintResoult(string masage, int res)
{
    Console.WriteLine(masage+res);

}

BigInteger Factorial(int num)
{
    BigInteger res =1;
    for(int i=1; i<=num; i++)
    {
        res *= i;
    }
    return res;
}

int numN = ReadData("put number N: ");
BigInteger res = Factorial (numN);
PrintResoult ("count:",(int)res);