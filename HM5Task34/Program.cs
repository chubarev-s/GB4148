// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
// * Отсортировать массив методом пузырька и подсчета. Сравнить быстродействие методов. 
// Проверку сортировки производить отдельно. Сначала запустить программу с одним методом сортировки,
// а затем с другим. Проверять на длине массива не мение 10000 элементов.


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

//Метод ввода длины массива
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

//Метод вывода числа чётных элементов массива
int evenNum(int[] arr)
{
    int res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            res++;
        }
    }
    return res;
}

//Метод пузырька
int[] bubbleSort(int[] arr)
{
    int buf;
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[i] > arr[j])
            {
                buf = arr[i];
                arr[i] = arr[j];
                arr[j] = buf;
            }

        }
    }
    return arr;
}
//Ниже закомментирован метод подсчёта, для его проверки необходимо убрать комментарии
/*
//Метод подсчёта
int[] CountingSort(int[] arr)
{
    
    int buf = 0;
    int max = arr[0];
    //Поиск макс.элемента массива 
    for (int i = 1; i < arr.Length; i++) 
    {
        if (arr[i] > max) 
        {
            max = arr[i];
        }
    }
    int min = arr.Min(); //поиск мин. эл-та массива 
    Console.WriteLine("MAX:  "+ max);   //вывод  макс и мин для наглядности
    Console.WriteLine("MIN:  "+ min);
    int[] res = new int[max - min + 1];
    for (int i = 0; i < res.Length; i++)
    {
        res[i] = 0;
    }
    //Print1Darray(res); //вывод массива для наглядности
    for(int i = 0; i < arr.Length; i++)
    {
        res[arr[i]-min]++; 
    }
   // Print1Darray(res);
    for(int i = min; i<=max; i++)
    {
        while (res[i-min]-- >0)
        {
            arr[buf]=i;
            buf++;
        }
    }
    return arr;
}
*/

int len = ReadData("Введите длину массива: ");
int[] arr = Gen1DArray(len, 100, 999);
Print1Darray(arr);
int[] bubbleArr = bubbleSort(arr);
Console.Write("Сортировка массива методом пузырька: ");
Print1Darray(bubbleArr);
int evenNumber = evenNum(bubbleArr);
Console.WriteLine("Чётных чисел в массиве: " + evenNumber);

//Ниже метод подсчёта, необходимо раскомментить
//---------------------------------------------------------------------------
//int[] countingArr = CountingSort(arr);
//Console.Write("Сортировка массива методом подсчёта: ");
//Print1Darray(countingArr);  
//---------------------------------------------------------------------------
//Измеренное время метода подсчёта(1000эл) = 00:00:00.0122599 
//Измеренное время метода пузырька(1000эл) = 00:00:00.0184035 







