// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


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

/*для проверки:
//Метод печати одномерного массива
void Print1Darray(int[] arr)
{

    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}*/
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

void SortArr(int[,] arr)
{
    int[] buf = new int[arr.GetLength(1)];
     for (int i = 0; i < arr.GetLength(0); i++) //GetLength - до конца строки/столбца
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
           buf[j] = arr[i,j]; 
        }
        //метод сортировки
        int count = 0;
       // Console.WriteLine("==================================");
        int min = buf.Min();
        //Console.WriteLine("Min = " + min);
        int max = buf.Max();
        //Console.WriteLine("Max = " + max);
        //Console.WriteLine("==================================");
        int[] buf_sort = new int[max - min + 1];
        for(int k = 0; k < buf.Length; k++)
        {
           buf_sort[buf[k]-min]++; 
        }
       // Print1Darray(buf_sort);
        //Console.WriteLine("==================================");
        for(int n = min; n<=max; n++)
        {
            while (buf_sort[n-min]-- >0)
            {
                buf[count]=n;
                count++;
            }
        }
       // Print1Darray(buf);
        //Console.WriteLine("==================================");
        
        for(int j = 0; j < arr.GetLength(1); j++) 
        {
            arr[i,j] = buf[arr.GetLength(1) - j -1];
        }
        
    }
}



int row = ReadData("Введите кол-во строк: ");
int col = ReadData("Введите кол-во столбцов: ");
int[,] arr2D = Gen2DArray(row, col, 0, 9);
Print2DArray(arr2D);
Console.WriteLine("==================================");
SortArr(arr2D);
Print2DArray(arr2D);
