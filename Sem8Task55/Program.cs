// Задача №55
// Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае,
// если это невозможно, программа должна вывести
// сообщение для пользователя.


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

//Метод замены строк на столбцы
int[,] StringReplacement(int[,] arr)
{
    long count = 0;
    int[,] res = new int[arr.GetLength(0),arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++) //GetLength - до конца строки(0)/столбца(1)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            res[i,j] = arr[j,i];
            count++;
        }
    }
    Console.WriteLine($"кол-во шагов: {count} ");
    return res;
}

//метод замены через void (дописать!)
void TransposeArr()
{

}

int row = ReadData("Введите кол-во строк: ");
int col = ReadData("Введите кол-во столбцов: ");
int[,] arr2D = Gen2DArray(row, col, 100, 999);
Print2DArray(arr2D);
int[,] res = StringReplacement(arr2D);
Console.WriteLine("========================================");
Print2DArray(res);