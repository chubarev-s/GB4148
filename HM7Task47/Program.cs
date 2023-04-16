// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// * При выводе матрицы показывать каждую цифру разного цвета(цветов всего 16)
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


//Ввод данных
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

//задаём двумерный массив, для этого вводим запятую: " [,] "
double[,] Gen2DArray(int countRow, int countColumn, int but, int top, int count)
{
    if (but > top)
    {
        int buf = top;
        top = but;
        but = buf;
    }
    double[,] res = new double[countRow, countColumn];

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            res[i, j] = new Random().Next(but, top + 1) + Math.Round(new Random().NextDouble(), count);
        }
    }
    return res;
}

//Метод печати 2 мерного массива 
void Print2DArray(double[,] arr)
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


//метод выбора цвета
void ChoseColor(double[,] arr, int count, int endOfLine)
{
    ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};
    double buf = 0;
    int buf0 = 0, buf1 = 0;
    int k = 0;
    for (int i = 0; i < arr.GetLength(0); i++) //GetLength - до конца строки/столбца
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            buf = arr[i, j];                        //записываем в буфферную переменную элемент массива
            buf = buf * Math.Pow(10, count);        //убираем запятую, получаем целое число
            //запишим, преобразовав в целочисл., значение буферной переменной (2 раза, т.к. первыое обнулится в ближайшем цикле)
            buf0 = (int)buf;
            buf1 = (int)buf;
            //цикл подсчёта кол-ва цифр
            while (buf0 != 0)
            {
                k++;
                buf0 = buf0 / 10;
            }
            //создаём массив для дальнейшой записи в него цифр числа
            double[] arrChoseNum = new double[k];
            //запишим число в массив по цифрам
            for (int n = 0; n < k; n++)
            {

                arrChoseNum[k - n - 1] = buf1 % 10;
                buf1 = buf1 / 10;
            }
            //Красим и выводим каждое число массива в случайный цвет
            for (int n = 0; n < k; n++)
            {
                Console.ForegroundColor = col[new Random().Next(0, 16)];
                Console.Write(arrChoseNum[n]);
                Console.ResetColor();
                if (n == k - count - 1) //т.к. нам надо вещественные числа, то нужна запятая :) 
                {
                    Console.ForegroundColor = col[new Random().Next(0, 16)];
                    Console.Write(",");
                    Console.ResetColor();
                }
            }
            Console.Write(" "); //ставим пробел между числами
            //обнулим переменные для повторного использования в цикле
            buf1 = 0;
            buf = 0;
            k = 0;
        }
        Console.WriteLine(); //переход на новуб строку
    }


}




int row = ReadData("Введите кол-во строк: ");
int col = ReadData("Введите кол-во столбцов: ");
int countNum = ReadData("Введите кол-во цифр, после < , > у вещественного числа: ");
double[,] arr2D = Gen2DArray(row, col, 1, 999, countNum); //задаём массив, 1 и 999 - границы чисел (с отрицательными числами работает не корректно)
ChoseColor(arr2D, countNum, col);

