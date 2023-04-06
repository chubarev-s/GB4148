// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

long ReadData(string msg)
{
    Console.Write(msg);
    long res = long.Parse(Console.ReadLine() ?? "0");
    return res;
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
//Метод суммирования цифр
long SummNum(long CountN, long num)
{
    long res = 0;
    for(int i=0; i<=CountN; i++)
    {
        res += num%10;
        num=num/10;
    }
    return res;
}
//Вводим число
long numN = ReadData("Введите число: ");
//считаем количество цифр в числе
long countNum = CountDigit(numN);
//производим суммирование цифр и выводим результат
long otvet = SummNum(countNum, numN);
Console.WriteLine("В числе "+numN+" сумма цифр = "+otvet);



