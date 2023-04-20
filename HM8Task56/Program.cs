// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
//====================================================================================================================================================



//Ввод данных
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

//задаём двумерный массив
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

//Метод подсчёты суммы эл-тов
int SummNumRow(int[,] arr)
{
    int res = 0;
    int min = 0;
    int rowInd = 0;
    for (int i = 0; i < arr.GetLength(0); i++) //GetLength - до конца строки/столбца
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
           res =+ arr[i,j];
        
        }
        if(min == 0)
        {
            min = res;
        }
        if(res < min)
        {
            min = res;
            rowInd = i+1;
        }

    } 
    return rowInd;
}
//=====================================================================================================
//Выполнение программы
Console.WriteLine("Задайте прямоугольный двумерный массив");
int row = ReadData("Введите кол-во строк: ");
int col = ReadData("Введите кол-во столбцов: ");
if(row <= col)
{
    Console.WriteLine("Заданный двумерный массив не прямогульный!");
}
else
{
    int[,] arr2D = Gen2DArray(row, col, 0, 9);
    Print2DArray(arr2D);
    Console.WriteLine("==================================");
    int res = SummNumRow(arr2D);
    Console.WriteLine($"В {res} строке наименьшая сумма элементов");

}



