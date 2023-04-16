// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание,
// что такого элемента нет.
// * Заполнить числами Фиббоначи и выделить цветом найденную цифру
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

//Ввод данных
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

//задаём двумерный массив, для этого вводим запятую: " [,] "
int[,] Gen2DArray(int countRow, int countColumn, int but, int top)
{
    if (but > top)
    {
        int buf = top;
        top = but;
        but = buf;
    }
    int[,] res = new int[countRow, countColumn];

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            res[i, j] = new Random().Next(but, top + 1);
        }
    }
    return res;
}

//Метод печати 2 мерного массива 
void Print2DArray(int[,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++) //GetLength - до конца строки/столбца
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

//Метод нахождения значения элемента
void ElementValue(int[,] arr, int x, int y)
{
    if (x <= arr.GetLength(0) && y <= arr.GetLength(1))
    {
        Console.WriteLine($"Значение элемента массива по позиции {x}, {y}: {arr[x - 1, y - 1]}");
    }
    else
    {
        Console.WriteLine("Такого элемента нет!");
    }
}

//заполнение методом Фиббоначи
long[,] FibArr(int countRow, int countColumn)
{
    long[,] res = new long[countRow, countColumn];
    long first = 0;
    long last = 1;
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            res[i, j] = res[i, j] + (first + last);
            (first, last) = (last, last + first);
        }

    }
    return res;
}

//Метод печати 2 мерного массива Фиббоначи
void PrintFibArray(long[,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++) //GetLength - до конца строки/столбца
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

//Метод выделения числа Фиббоначи
void PrintFibNum(long[,] arr, long num)
{
    ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};
    for (int i = 0; i < arr.GetLength(0); i++) //GetLength - до конца строки/столбца
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] == num)
            {
                Console.ForegroundColor = col[new Random().Next(0, 16)];
                Console.Write(arr[i, j] + " ");
                Console.ResetColor();
            }
            else
            {
                Console.Write(arr[i, j] + " ");
            }
        }
        Console.WriteLine();
    }
}



int row = ReadData("Введите кол-во строк: ");
int col = ReadData("Введите кол-во столбцов: ");
// int[,] arr2D = Gen2DArray(row, col, 1, 999); 
// Print2DArray(arr2D);
// int x = ReadData("Введите номер строки интересующего элемента: ");
// int y = ReadData("Введите номер столбца интересующего элемента: ");
// ElementValue(arr2D, x, y);
long[,] arrFib = FibArr(row, col);
PrintFibArray(arrFib);
long num = ReadData("Введите искомое число Фиббоначи: ");
PrintFibNum(arrFib, num);