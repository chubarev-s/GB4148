/*Задача №5
Напишите программу, которая на вход принимает одно число (N),а 
на выходе показывает все целые числа в промежутке от -N до N.*/

//Выводим запрос на ввод числа
Console.Write("Введите число: ");
//Считываем данные с консоли
string? numLine = Console.ReadLine(); 

if(numLine!=null)
{
    int numN = int.Parse(numLine);

    int startNum = numN*(-1);

    string res = string.Empty;
    
    while(startNum <= numN)
    {
        res = res + startNum + " "; //накапливаем значения
        startNum++;
    }

    Console.WriteLine(res);

}