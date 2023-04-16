// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// * Дополнительно диагональ выделить разным цветом.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


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

//Метод печати 2 мерного массива, цветные диагонали
void Print2DArrayColor(int[,] arr)
{
    int colCount = 0;
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
            if (colCount > 16)
            {
                colCount=0;
            }
            //colCount = j + 1;   //столбцы
            Console.ForegroundColor = col[colCount];
            Console.Write(arr[i, j] + " ");
            Console.ResetColor();
            colCount++;
            
        }
        colCount = i + 1;       //диагональ.
        Console.WriteLine();
    }
}

//Метод нахождения среднего арифметического элементов в каждом столбце
void Average(int[,] arr, int row, int column)
{
    double[] Average = new double[column];
    for (int i = 0; i < arr.GetLength(0); i++) //GetLength - до конца строки/столбца
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Average[j] = Average[j] + arr[i, j];
        }

    }
    for (int i = 0; i < Average.Length; i++)
    {
        Average[i] = Average[i] / row;
        Console.WriteLine(i + 1 + " - " + Math.Round(Average[i], 2) + "; ");
    }
}

int row = ReadData("Введите кол-во строк: ");
int col = ReadData("Введите кол-во столбцов: ");
int[,] arr2D = Gen2DArray(row, col, 1, 999);
Print2DArray(arr2D);
Console.WriteLine("=======================");
Console.WriteLine("Среднее арифметическое столбцов: ");
Average(arr2D, row, col);
Console.WriteLine("=======================");
Print2DArrayColor(arr2D);





