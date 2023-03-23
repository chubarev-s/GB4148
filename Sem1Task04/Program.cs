/*Задача №7
Напишите программу, 
которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.*/

//Выводим запрос на ввод числа
Console.Write("Введите трёхзначное число: ");
//Считываем данные с консоли
string? numLine = Console.ReadLine(); 

if(numLine!=null)
{
    // char[] charArr = numLine.ToCharArray();
   // Console.WriteLine(charArr[charArr.Line-1]);
    int num = int.Parse(numLine);
    int res = num % 10;

    Console.Write("Последняя цифра введённого числа: ");
    Console.Write(res);
}