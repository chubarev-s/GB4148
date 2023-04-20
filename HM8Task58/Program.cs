// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


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

//Метод умножения матриц
int[,]  MatrixMultiplication(int[,] arr1, int[,] arr2)
{
    int[,] res = new int[ arr1.GetLength(0), arr2.GetLength(1)];
    for (int i = 0; i < arr1.GetLength(0); i++) //GetLength - до конца строки/столбца
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            for (int k = 0; k < arr2.GetLength(0); k++)
            {
                res[i,j] += arr1[i,k]*arr2[k,j];
            }
        }
        
    }
    return res; 
}

//=====================================================================================================
//Выполнение программы
Console.WriteLine("Задайте первую матрицу");
int row1 = ReadData("Введите кол-во строк: ");
int col1 = ReadData("Введите кол-во столбцов: ");
int[,] arr2D = Gen2DArray(row1, col1, 0, 9);
Console.WriteLine("==================================");
Console.WriteLine("Полученная матрица:");
Console.WriteLine("==================================");
Print2DArray(arr2D);
Console.WriteLine("==================================");
Console.WriteLine("Задайте вторую матрицу. !Помните что число столбцов первой матрицы должно быть равно числу строк второй!");
int row2 = ReadData("Введите кол-во строк: ");
int col2 = ReadData("Введите кол-во столбцов: ");
if(col1 != row2)
{
    Console.WriteLine("Заданные матрицы нельзя умножить!");
}
else
{
    
    int[,] secondArr2D = Gen2DArray(row2, col2, 0, 9);
    Print2DArray(secondArr2D);
    Console.WriteLine("==================================");
    int[,] Multiplication = MatrixMultiplication(arr2D, secondArr2D);
    Print2DArray(Multiplication);
}
