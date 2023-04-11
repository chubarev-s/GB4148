// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
// * Отсортируйте массив методом вставки, а затем найдите разницу между первым и последним элементом.


//Метод ввода длины массива
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

//Метод заполнение массива
double[] Gen1DArray(int len, int but, int top)
{
    double[] res = new double[len];
    for (int i = 0; i < len; i++)
    {
        res[i] = new Random().Next(but, top + 1)+new Random().NextDouble(); //+new Random().NextDouble(); пишет только после запятной, также можно округлить
    }
    return res;
}

//Метод печати одномерного массива
void Print1Darray(double[] arr)
{

    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

int len = ReadData("Введите длину массива: ");
double[] arr = Gen1DArray(len, 0, 999);
Print1Darray(arr);
double min = arr.Min();
Console.WriteLine("Минимальный элемент массива: " + min);
double max = arr.Max();
Console.WriteLine("Максимальны элемент массива: " + max);
double res = max-min;
Console.WriteLine("Разница между максимальным и минимальным элементом массива: " + res);
