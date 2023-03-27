/*Задача 8: Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8     */

//Просим ввести число
Console.Write("Введите число: ");
string? inLine = Console.ReadLine();        //Считываем данные с консоли

if(inLine!=null)
{
    int Num = int.Parse (inLine);
    
    int numN = 1;
    string res = string.Empty;
    while(numN<(Num+1))
    {
        if(numN%2==0)
            {
                res = res + numN + " "; //накапливаем значения    
            }
        numN++;
    }
    Console.WriteLine(res);
}

