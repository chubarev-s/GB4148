// Задача №49
// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

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
    int[,] res = new int[countRow,countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for(int j=0; j < countColumn; j++)
        {
            res[i,j] = new Random().Next(but, top + 1);
        }
    }
    return res;
}


int[,] SquareOfEvenIndices(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i=i+2)
    {
        for(int j=0; j < arr.GetLength(1); j=j+2)
        {
            if(i%2==0 && j%2==0)
            arr[i,j] = arr[i,j]*arr[i,j];
        }
    }
    return arr;
}

//Метод печати 2 мерного массива 
void Print2DArray(int[,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++) //GetLength - до конца строки/столбца
    {
        for(int j=0; j < arr.GetLength(1); j++)
        {           
            Console.Write(arr[i,j]+" ");
        }
        Console.WriteLine();
    }
}




int row = ReadData("Введите кол-во строк: ");
int col = ReadData("Введите кол-во столбцов: ");
int[,] arr2D = Gen2DArray(row, col, 10, 99);
int[,] arr2DNew = SquareOfEvenIndices(arr2D);
Print2DArray(arr2DNew);
