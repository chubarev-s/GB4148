// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
// * Пользователь вводит число нажатий, затем программа следит за нажатиями и выдает сколько чисел больше 0 было введено.(не доделал)


//Ввод чисел:
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}


//Ввод массива:
int[] ReadArr(int len)
{
    int[] arr = new int[len];
    for(int i = 0; i<arr.Length;i++)
    {
        arr[i] = ReadData($"Введите {i+1}-й элемент массива: ");
    }
    return arr;
}
//Метод подсчёта чисел > 0
int CountNum(int[] arr)
{
    int count = 0;
    for(int i=0; i<arr.Length;i++)
    {
        if(arr[i]>0)
        {
            count++;
        }
    }
    return count;
}
/*
//Отслеживание нажатия клашиш
int[] KeyPress(int count)
{
    int keyPressCount = 0;
    int[] res = new int[count];
    ConsoleKeyInfo Press;
        do
        {
            Press = Console.ReadKey();
            //int Key = Convert.ToInt32 (Console.ReadKey());
            Console.WriteLine(Press.Key);
            //res[keyPressCount] = Key;  
            keyPressCount++;
        }
        while (keyPressCount < count);
    return res;
}*/

int len = ReadData("Введите длину массива: ");
int[] arr = ReadArr(len);
int x = CountNum(arr);
Console.WriteLine($"Чисел больше 0: {x}");

// int count = ReadData("Введите количество нажатий: ");
// int[] arr = KeyPress(count);
// int x = CountNum(arr);
// Console.WriteLine($"Чисел больше 0: {x}");





