// Задача №26 
// Напишите программу, которая принимает на вход
// число и выдаёт количество цифр в числе.


//Read data
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}
//Translate res
void PrintResoult(string msg, long res)
{
    Console.WriteLine(msg+res);

}

//метод подсчёта количества цифр
long CountDigit(long num)
{
    long res = 0;
    while (0<num)
    {
        res++;
        num=num/10;
    }
    return res;
}

long numN = ReadData("Введите число: ");
long result = CountDigit(numN);
PrintResoult("В числе: ", (long)result);
