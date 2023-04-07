// Задача №37 
// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.

//Ввод числа
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
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

//Заполнение массива
int[] Gen1DArray(int len, int top, int but)
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


//Метод нахождение пар
int[] ConverArr(int[] arr)
{
    int len = (arr.Length % 2 == 0) ? arr.Length / 2 : arr.Length / 2 + 1;
    int[] outArr = new int[len];

    for (int i = 0; i < len; i++)
    {
        outArr[i] = arr[i] * arr[arr.Length - 1 - i];
    }

    return outArr;
}

int Length = ReadData("Введите длину массива: ");
int[] arr = Gen1DArray(Length, 999, -999);
Print1Darray(arr);
int[] newArr = ConverArr(arr);
Print1Darray(newArr);