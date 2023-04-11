// Задача №39  (Исправить!)
// Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)

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


//Метод разворота исх.массивом
void SwapArray(int[] arr)
{
    int buf = 0;
    for(int i=0; i<arr.Length/2; i++)
    {
        buf = arr[i];
        arr[i] = arr[arr.Length-i]; 
        arr[arr.Length-i]=buf;
    }
}

// Метод разворота с исп.второго массива
int[] SwapNewArr(int[] arr)
{
    int[] outArr = new int[arr.Length];
    for(int i=0; i<arr.Length; i++)
    {
        outArr[i]=arr[arr.Length-1-i];
    }
    return outArr;
}

//int len = ReadData("Введите длину массива: ");
int[] arr = Gen1DArray(10, 0, 100);
Print1Darray(arr);
int[] SwapNew = SwapNewArr(arr);
SwapArray(arr);
Print1Darray(SwapNew);
Print1Darray(arr);