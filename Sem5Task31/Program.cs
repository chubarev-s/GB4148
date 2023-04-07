// Задача №31 
// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
//  Найдите сумму отрицательных и положительных элементов массива.

//задаём глоб.перем.
int globPosSum = 0;
int globNegSum = 0;

//метод подсчёта вар.1
void NegPosSumV1(int[] arr)
{
    for(int i=0; i<arr.Length;i++)
    {
        if(arr[i]>0)
        {
            globPosSum += arr[i];
        }
        else
        {
            globNegSum += arr[i];
        }
    }
}
//метод подсчёта вар.2 (инкапсуляция данных)
int[] NegPosSumV2(int[] arr)
{
    int positivSum = 0;
    int negativSum = 0;
    int[] outArr = new int[2];
    for(int i=0; i<arr.Length;i++)
    {
        if(arr[i]>0)
        {
            positivSum += arr[i];
        }
        else
        {
            negativSum += arr[i];
        }
    }
    outArr[0] = positivSum;
    outArr[1] = negativSum;
    return outArr; 
}
//метод подсчёта вар.3
(int positiv, int negotiv) NegPosSumV3(int[] arr)
{
    int positivSum = 0;
    int negativSum = 0;
    for(int i=0; i<arr.Length;i++)
    {
        
        if(arr[i]>0)
        {
            positivSum += arr[i];
        }
        else
        {
            negativSum += arr[i];
        }
    }
    return(positivSum, negativSum);
}
//Метод печати одномерного массива
void Print1Darray(int []arr)
{
    Console.Write("[");
    for(int i = 0; i<arr.Length-1; i++)
    {
        Console.Write(arr[i]+",");
    }
    Console.WriteLine(arr[arr.Length-1] + "]");
}

//Заполнение массива
int[] Gen1DArray(int len, int top, int but)
{
    if(but>top)
    {
        int buf = top;
        top = but;
        but = buf;
    }
    int[] res=new int[len];
    for(int i=0; i<len; i++)
    {
        res[i]= new Random().Next(but, top+1);
    }
    return res;
}

int[] testArr = Gen1DArray(12,-9,9);
NegPosSumV1(testArr);
Print1Darray(testArr);
int[] res = NegPosSumV2(testArr);
(int positiv, int negotiv) sum = NegPosSumV3(testArr);

Console.WriteLine("Сумма + чисел V1: "+ globPosSum);
Console.WriteLine("Сумма - чисел V1: "+ globNegSum);

Console.WriteLine("Сумма + чисел V2: "+ res[0]);
Console.WriteLine("Сумма - чисел V2: "+ res[1]);

Console.WriteLine("Сумма + чисел V3: "+ sum.positiv);
Console.WriteLine("Сумма - чисел V3: "+ sum.negotiv);




