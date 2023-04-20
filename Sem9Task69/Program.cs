//==========================================
//#69 Напишите прграмму, которая будет принимать 2 числа А и В
// возыедите А в степень В с помощью рекурсии
//==========================================

//========================================================
//Вариант 1:
//========================================================
// //Ввод данных
// int ReadData(string msg)
// {
//     Console.Write(msg);
//     int res = int.Parse(Console.ReadLine() ?? "0");
//     return res;
// }

// //Рекур.метод
// long PowRec(int a, int b)
// {
//     if (b > 0)
//     {
//         return a * PowRec(a, b - 1);
//     }
//     else
//     {
//         return 1;
//     }

// }

// int A = ReadData("Введите число: ");
// int B = ReadData("Введите степень числа: ");
// long PowAB = PowRec(A,B);
// Console.Write(PowAB);


//========================================================
//Вариант 2:
//========================================================
//Ввод данных
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}
//Рекур.метод
long PowRec(int a, int b)
{
    if (b == 2)
    {
       return 4;
    }
    else
    {
        return PowRec(a,b/2)*PowRec(a,b/2);
    }

}

int A = ReadData("Введите число: ");
int B = ReadData("Введите степень числа: ");
long PowAB = PowRec(A,B);
Console.Write(PowAB);
