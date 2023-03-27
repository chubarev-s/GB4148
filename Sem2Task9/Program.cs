/* Задача №9
Напишите программу, которая выводит случайное число 
из отрезка [10, 99] и показывает наибольшую цифру числа. */

System.Random numSintezator = new System.Random();

//Вариант 1
int rndNum = numSintezator.Next(10,100);                //Последнее число не входит, поэтому 100, а не 99
Console.WriteLine(rndNum);

//создаём 2 переменных
int firstNum = (int)(rndNum/10);                 //находим первое число, указываем (short)() т.к. будет ругаться, из-за возможной потери данных, или (int)
int secondNum = (int)(rndNum%10);                //находим второе число

if(firstNum>secondNum)
{
    Console.WriteLine("Первое число  " + firstNum + " больше второго " + secondNum);
}
else
{
    Console.WriteLine("Второе число  " + secondNum + " больше первого " + firstNum);
}

//вариант 2
char[] digits = numSintezator.Next(10,100).ToString().ToCharArray();
Console.WriteLine(digits);

//23 -> "23" -> ['2','3']

firstNum = (int)(digits[0])-48;             //48 т.к. в char 0 = 48 (1 = 49 и т.д.) согласно табл.ASCII    
secondNum = (int)(digits[1])-48;

//<переменная> = (условие)?<значение1>:<значение2>;
/* if(условие)
    {
        <переме> = <знач>;
    }
    else ...
    */
int res = (firstNum>secondNum)?firstNum:secondNum;
Console.WriteLine(res);

//вариант 3
//Массив с ответами. массив[89] = 9 и т.п.
