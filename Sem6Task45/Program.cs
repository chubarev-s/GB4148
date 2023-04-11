// Задача №45
// Напишите программу, которая будет создавать копию заданного одномерного массива с помощью поэлементного копирования.


//Метод заполнение массива
int[] Gen1DArray(int len, int but, int top)
{
    if (but > top)
    {
        int buf = top;
        top = but;
        but = buf;
    }
    int[] res = new int[len];
    for (int i = 0; i < len; i++)
    {
        res[i] = new Random().Next(but, top + 1);
    }
    return res;
}

//Метод печати одномерного массива
void Print1Darray(int[] arr)
{

    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

// //Метод ввода длины массива
// int ReadData(string msg)
// {
//     Console.Write(msg);
//     int res = int.Parse(Console.ReadLine() ?? "0");
//     return res;
// }

//метод копирования
int[] CopyArr(int[] arr)
{
    int[] outArr = new int[arr.Length];
    for(int i=0;i<arr.Length;i++)
    {
        outArr[i]=arr[i];
    }
    return outArr;
}

int[] arr = Gen1DArray(10, 0, 100);
Print1Darray(arr);
int[] copyArr = CopyArr(arr);
Print1Darray(copyArr);

int[] outArr = new int[arr.Length];
arr.CopyTo(outArr, 0);
Print1Darray(outArr);




















