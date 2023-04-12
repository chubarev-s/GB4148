// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
//* Найдите все пары в массиве и выведите пользователю (Доделать!)

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

//Метод суммы чисел, стоящих на чётных позициях массива
long SumNumEvenPos(int[] arr)
{
    int res = 0;
    for (int i = 0; i < arr.Length; i+=2)
    {
        res = res + arr[i];
    }
    return res;
}

//Метод нахождения пар
void PairsOfNumbers(int[] arr)
{
    
    int[] res = new int[arr.Length];
    for(int i = 0; i < arr.Length-1; i++)
    {
        for(int j = i+1; j < arr.Length; j++)
        {
            if(arr[i] == arr[j])
            {
                res[i]=i;
                res[j]=j;
                Console.WriteLine($"Пара {arr[i]}, {arr[j]} с индексами {i}, {j}");
                break;
            }
        }
    }
}


int len = ReadData("Введите длину массива: ");
int[] arr = Gen1DArray(len, 0, 3);
Print1Darray(arr);
long sum = SumNumEvenPos(arr);
Console.WriteLine("Сумма чисел, стоящих на чётных позициях массива, равна: "+sum);
PairsOfNumbers(arr);

