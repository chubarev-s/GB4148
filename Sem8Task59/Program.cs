// Задача №59 (Доделать!!!)
// Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и
// столбец, на пересечении которых расположен
// наименьший элемент массива.


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

//Метод нахождения мин.эл-та
int[] FindMinElm(int[,] arr)
{
    int[] res = new int[2];
    int minElm = int.MaxValue;
    for (int i = 0; i < arr.GetLength(0); i++) //GetLength - до конца строки/столбца
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if(minElm>arr[i,j])
            {
                minElm=arr[i,j];
                res[0]=i;
                res[1]=j;
            }  
        }
        
    }
    Console.WriteLine("========================================");
    Console.WriteLine($"Минимальное число: {minElm}, позиция в матрице {res[1]+1}, {res[0]+1}");
    return res;
}

//Метод удаления столбца и строки
int[,] DelRowCol(int[,] arr, int[] res)
{
    int[,] rebuildArr = new int[arr.GetLength(0)-1, arr.GetLength(1)-1];
    int m=0, n=0;
    for (int i = 0; i < rebuildArr.GetLength(0); i++) //GetLength - до конца строки/столбца
    {
        for (int j = 0; j < rebuildArr.GetLength(1); j++)
        {
            m=0;
            if(i != res[0] && j != res[1])
            {
                rebuildArr[i,j] =arr[i,j];
                m++;
            }
            if(i != res[0])
            {
                n++;
            }

        }
        
    }
    return rebuildArr;
}


int row = ReadData("Введите кол-во строк: ");
int col = ReadData("Введите кол-во столбцов: ");
int[,] arr2D = Gen2DArray(row, col, 100, 999);
Print2DArray(arr2D);
int[] res = FindMinElm(arr2D);
int[,] rebuildArr = DelRowCol(arr2D, res);
Console.WriteLine("========================================");
Print2DArray(rebuildArr);