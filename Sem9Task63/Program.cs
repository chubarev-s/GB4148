// ---------------------------------------------------------------------
//                                 Задача 63
// Задайте значение N. Напишите программу, которая выведет все натуральные числа в 
// промежутке от N до 1. Выполнить с помощью рекурсии.
// ---------------------------------------------------------------------



//Ввод данных
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}


void LineGenRec(int numN)
{
    Console.Write(numN + " ");
    if(numN<=1)
    {
     
    }
    else
    {
        LineGenRec(numN-1);
    }
}
 
int numN = ReadData("Введите число: ");
LineGenRec(numN);

