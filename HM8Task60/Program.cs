// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


//Ввод данных
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

//задаём трёхмерный массив
int[,,] Gen3DArray(int countRow, int countColumn, int z, int but, int top)
{
    if (but > top)
    {
        int buf = top;
        top = but;
        but = buf;
    }
    int[,,] res = new int[countRow, countColumn, z];

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            for (int k = 0; k < countColumn; k++)
            {
                res[i, j, k] = new Random().Next(but, top + 1);
            }
        }
    }
    return res;
}

//Метод печати 3 мерного массива 
void Print3DArray(int[,,] arr)
{
    int k = 0;
    int i = 0;
    int j = 0;
    
     //GetLength - до конца строки/столбца
    for (k = 0; k < arr.GetLength(2); k++)
    {
        for (j = 0; j < arr.GetLength(1); j++)
        {                      
            for (i = 0; i < arr.GetLength(1); i++)
            {
                Console.Write(arr[i, j, k] + $"({i},{j},{k}) ");
            }
            Console.WriteLine();   
        }
    }
}

//=====================================================================================================
//Выполнение программы
Console.WriteLine("Задайте первую матрицу");
int row1 = ReadData("Введите кол-во строк: ");
int col1 = ReadData("Введите кол-во столбцов: ");
int z = ReadData("Введите кол-во третьих эл-тов массива: ");
int[,,] arr3D = Gen3DArray(row1, col1, z, 0, 99);
Console.WriteLine("==================================");
Console.WriteLine("Полученная матрица:");
Console.WriteLine("==================================");
Print3DArray(arr3D);








