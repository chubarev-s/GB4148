/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
 какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3  */

//Просим ввести два числа
Console.Write("Введите первое число: ");
string? inLine1 = Console.ReadLine();        //Считываем данные с консоли
Console.Write("Введите второе число: ");
string? inLine2 = Console.ReadLine();

//Проверяем, чтобы данные были не пустые
if(inLine1!=null)
{
    int inNumber1 = int.Parse(inLine1); //преобразуем в целочисленное значение
    
    if(inLine2!=null)
    {
        int inNumber2 = int.Parse(inLine2); //преобразуем в целочисленное значение
        int max = inNumber1;
        int min = inNumber2;
        if(inNumber1<inNumber2)
        {
            max = inNumber2;
            min = inNumber1;
        }
        Console.Write("Наибольшее число: ");
        Console.WriteLine(max);
        Console.Write("Наименьшее число: ");  
        Console.WriteLine(min);
    }


}