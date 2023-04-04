// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
// * Вывести таблицу с границами и значениями друг над другом

//Вариант 1:
// //метод ввода числа
// int ReadData(string msg)
// {
//     Console.Write(msg);
//     int res = int.Parse(Console.ReadLine() ?? "0");
//     return res;
// }

// //метод создания строки таблицы
// string LineGen(int num, int pow)   //т.к. выдаём строку, то используем string
// {
//     string res = string.Empty; //альт запись string res = ""; 
//     for (int i = 1; i <= num; i++)
//     {
//         res += Math.Pow(i, pow) + " ";
//     }
//     return res;
// }

// int numN = ReadData("Введите число: ");
// Console.WriteLine(LineGen(numN, 1));
// Console.WriteLine(LineGen(numN, 3));

//-------------------------------------------------------------------------------
//-------------------------------------------------------------------------------

//Вариант 2, с граффикой (до 15, чтоб помещалось в консоли):
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
        //Делаем ровные столбцы, для однозначных чисел:
        if (i == 1)
        {
            if (pow == 1)
            {
                res += " " + Math.Pow(i, pow) + "\u2502";
            }
            else
            {
                res += " " + Math.Pow(i, pow) + "\u2502";
            }
        }
        if (1 < i && i < 3)
        {
            if (pow == 1)
            {
                res += " " + Math.Pow(i, pow) + " " + "\u2502";
            }
            else
            {
                res += " " + Math.Pow(i, pow) + " " + "\u2502";
            }
        }
        //для двузначных:
        if (2 < i && i < 5)
        {
            if (pow == 1)
            {
                res += "  " + Math.Pow(i, pow) + " " + "\u2502";
            }
            else
            {
                res += " " + Math.Pow(i, pow) + " " + "\u2502";
            }
        }
        //для 3х-значных
        if (4 < i && i < 10)
        {
            if (pow == 1)
            {
                res += "  " + Math.Pow(i, pow) + " " + " " + "\u2502";
            }
            else
            {
                res += " " + Math.Pow(i, pow) + " " + "\u2502";
            }
        }
        //для остальных: 
        if (i > 9)
        {
            if (pow == 1)
            {
                res += "  " + Math.Pow(i, pow) + " " + " " + "\u2502";
            }
            else
            {
                res += " " + Math.Pow(i, pow) + " " + "\u2502";
            }
        }
    }
    return res;
}

//методы для верхней, центральной и нижней границы
void UpLineGen(int numLength)
{
    int factorN = 0;   //множитель для дальнейшей прорисовки ровной рамки.
    if (numLength < 3)
    {
        Console.Write("\u2554");
        for (int N = 0; N < numLength*3; N++)
        {
            Console.Write("\u2550");
        }
        Console.WriteLine("\u2557");
    }
    
    if (numLength == 3)
    {
        Console.Write("\u2554");
        for (int N = 0; N < numLength*4; N++)
        {
            Console.Write("\u2550");
        }
        Console.WriteLine("\u2557");
    }
    
    if (numLength > 3 && numLength < 10)
    {
        for(int i=3; i<numLength; i++)
        {
            factorN++;
        }
        Console.Write("\u2554");
        for (int N = 0; N < (numLength+factorN)*3+2; N++)
        {
            Console.Write("\u2550");
        }
        Console.WriteLine("\u2557");
        factorN=0;
    }
    if (numLength > 9)
    {
        for(int i=3; i<numLength; i++)
        {
            factorN++;
        }
        Console.Write("\u2554");
        for (int N = 0; N < (numLength+factorN)*3+3; N++)
        {
            Console.Write("\u2550");
        }
        Console.WriteLine("\u2557");
    }
    

}
void CenterLineGen(int numLength)
{
     int factorN = 0;   //множитель для дальнейшей прорисовки ровной рамки.
    if (numLength < 3)
    {
        Console.Write("\u255F");
        for (int N = 0; N < numLength*3; N++)
        {
            Console.Write("\u2500");
        }
        Console.WriteLine("\u2562");
    }
    
    if (numLength == 3)
    {
        Console.Write("\u255F");
        for (int N = 0; N < numLength*4; N++)
        {
            Console.Write("\u2500");
        }
        Console.WriteLine("\u2562");
    }
    
    if (numLength > 3 && numLength < 10)
    {
        for(int i=3; i<numLength; i++)
        {
            factorN++;
        }
        Console.Write("\u255F");
        for (int N = 0; N < (numLength+factorN)*3+2; N++)
        {
            Console.Write("\u2500");
        }
        Console.WriteLine("\u2562");
        factorN=0;
    }
    if (numLength > 9)
    {
        for(int i=3; i<numLength; i++)
        {
            factorN++;
        }
        Console.Write("\u255F");
        for (int N = 0; N < (numLength+factorN)*3+3; N++)
        {
            Console.Write("\u2500");
        }
        Console.WriteLine("\u2562");
    }
}
void DownLineGen(int numLength)
{
   int factorN = 0;   //множитель для дальнейшей прорисовки ровной рамки.
    if (numLength < 3)
    {
        Console.Write("\u255A");
        for (int N = 0; N < numLength*3; N++)
        {
            Console.Write("\u2550");
        }
        Console.WriteLine("\u255D");
    }
    
    if (numLength == 3)
    {
        Console.Write("\u255A");
        for (int N = 0; N < numLength*4; N++)
        {
            Console.Write("\u2550");
        }
        Console.WriteLine("\u255D");
    }
    
    if (numLength > 3 && numLength < 10)
    {
        for(int i=3; i<numLength; i++)
        {
            factorN++;
        }
        Console.Write("\u255A");
        for (int N = 0; N < (numLength+factorN)*3+2; N++)
        {
            Console.Write("\u2550");
        }
        Console.WriteLine("\u255D");
        factorN=0;
    }
    if (numLength > 9)
    {
        for(int i=3; i<numLength; i++)
        {
            factorN++;
        }
        Console.Write("\u255A");
        for (int N = 0; N < (numLength+factorN)*3+3; N++)
        {
            Console.Write("\u2550");
        }
        Console.WriteLine("\u255D");
    } 
}

//Вводим число:
int numN = ReadData("Введите число: ");

//Рисуем верхнюю рамку
UpLineGen(numN);

//Рисуем боковую рамку и заполняем первую строку
Console.Write("\u2551");
Console.Write(LineGen(numN, 1));
Console.WriteLine("\u2551");

//Рисуем боковую рамку и границу между строк
CenterLineGen(numN);

//Рисуем боковую рамку и заполняем вторую строку
Console.Write("\u2551");
Console.Write(LineGen(numN, 3));
Console.WriteLine("\u2551");

//Рисуем нижнюю рамку 
DownLineGen(numN);