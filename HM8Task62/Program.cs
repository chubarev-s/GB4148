// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

//задаём двумерный массив
int[,] Gen2DArray()
{
 
    int[,] res = new int[4, 4];
    int k = 1;
    for (int j = 0; j < 3; j++)
        {
            res[0, j] = k;
            k++;
        }
    for (int j = 0; j < 3; j++)
        {
            res[j, 3] = k;
            k++;
        }
    for (int j = 3; j > 0; j--)
        {
            res[3, j] = k;
            k++;
        }
    for (int j = 3; j > 0; j--)
        {
            res[j, 0] = k;
            k++;
        }
    for (int j = 1; j < 3; j++)
        {
            res[1, j] = k;
            k++;
        }
    for (int j = 2; j > 0; j--)
        {
            res[2, j] = k;
            k++;
        }
    return res;
}

Console.WriteLine("========================================================");
Console.WriteLine("Спиральное заполнение массива 4 на 4, числами от 1 до 16");
Console.WriteLine("========================================================");
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
int[,] matrix = Gen2DArray();
 Print2DArray(matrix);


Console.WriteLine("========================================================");