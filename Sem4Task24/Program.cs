// Задача 24
// Напишите программу, которая принимает на вход
// число (А) и выдаёт сумму чисел от 1 до А.

//Read data
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

//Translate res
void PrintResoult(string msg, int res)
{
    Console.WriteLine(msg+res);

}


long SumSimple(int numA)
{
    long sum = 0;
for(int i=1; i<=numA; i++)
{
    sum+=i;  //sum=sum+i

}
    return sum;
}

long SumGauss(int numA)
{
    return((1+(long)numA)*(long)numA)/2;
}

int numberA = ReadData("Введите число А: ");

DateTime d1 = DateTime.Now;
long res1= SumSimple(numberA);
Console.WriteLine(DateTime.Now - d1);

DateTime d2 = DateTime.Now;
long res2= SumGauss(numberA);
Console.WriteLine(DateTime.Now - d2);

PrintResoult("Сумма чисел от 1 до А(простой метод): ", (int)res1);
PrintResoult("Сумма чисел от 1 до А: ", (int)res2);
